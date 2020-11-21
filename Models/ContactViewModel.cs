using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MySendGrid;

namespace MGRescue_System.Models
{
    public class ContactViewModel
    {
        [Required]
        [Display(Name = "From Email Address")]
        public string FromEmailAddress { get; set; }

        public string Alias { get; set; }

        //[Required]
        //[Display(Name = "To Email Address")]
        //public string ToEmailAddress { get; set; }

        [Display(Name = "Cc Email Address")]
        public string CcEmailAddress { get; set; }
        [Display(Name = "Bcc Email Address")]
        public string BccEmailAddress { get; set; }
        [Required]
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Body")]
        public string Body { get; set; }
        public string PlainTextContent { get; set; }
        [JsonProperty(PropertyName = "content", IsReference = false)]
        public List<Content> Contents { get; set; }
        [JsonIgnore]
        public string HtmlContent { get; set; }

        internal string Serialize()
        {
            if (this.PlainTextContent != null || this.HtmlContent != null)
            {
                this.Contents = new List<MySendGrid.Content>();
                if (this.PlainTextContent != null)
                {
                    this.Contents.Add(new PlainTextContent(this.PlainTextContent));
                }

                if (this.HtmlContent != null)
                {
                    this.Contents.Add(new HtmlContent(this.HtmlContent));
                }

                this.PlainTextContent = null;
                this.HtmlContent = null;
            }

            if (this.Contents != null)
            {
                if (this.Contents.Count > 1)
                {
                    // MimeType.Text > MimeType.Html > Everything Else
                    for (var i = 0; i < this.Contents.Count; i++)
                    {
                        if (string.IsNullOrEmpty(this.Contents[i].Type) || string.IsNullOrEmpty(this.Contents[i].Value))
                        {
                            this.Contents.RemoveAt(i);
                            i--;
                            continue;
                        }

                        if (this.Contents[i].Type == MimeType.Html)
                        {
                            var tempContent = new Content();
                            tempContent = this.Contents[i];
                            this.Contents.RemoveAt(i);
                            this.Contents.Insert(0, tempContent);
                        }

                        if (this.Contents[i].Type == MimeType.Text)
                        {
                            var tempContent = new Content();
                            tempContent = this.Contents[i];
                            this.Contents.RemoveAt(i);
                            this.Contents.Insert(0, tempContent);
                        }
                    }
                }
            }

            var jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Include,
                StringEscapeHandling = StringEscapeHandling.EscapeHtml
            };

            return JsonConvert.SerializeObject(
                                               this,
                                               Formatting.None,
                                               jsonSerializerSettings);
        }
    }
}