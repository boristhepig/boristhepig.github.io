using MGRescue_System.Models;
using Microsoft.AspNet.Identity;
using MySendGrid;
using SendGrid.ASPSamples;
using System;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MGRescue_System
{
    public class SendGridEmailService
    {
        private readonly SendGridClient _client;
        private string apiKey = ConfigurationManager.AppSettings["SendGridApiKey"];
        private static readonly string MessageId = "X-Message-Id";
        public string callbackUrl = "/Account/ConfirmEmail";
        private ApplicationUserManager userManager;

        //
        // Summary:
        //     Provides extension methods for System.Web.HttpContextBase.
        

        


        public SendGridEmailService()
        {
            _client = new SendGridClient(apiKey);
        }


        //public EmailResponse Send(EmailContract contract)
        //{

        //    var emailMessage = new SendGridMessage()
        //    {
                
        //        From = new EmailAddress(contract.FromEmailAddress, contract.Alias),
        //        Subject = contract.Subject,
        //        HtmlContent = contract.Body
        //    };

        //    emailMessage.AddTo(new EmailAddress("d.dubois@live.co.uk"));
        //    if (!string.IsNullOrWhiteSpace(contract.BccEmailAddress))
        //    {
        //        emailMessage.AddBcc(new EmailAddress(contract.BccEmailAddress));
        //    }

        //    if (!string.IsNullOrWhiteSpace(contract.CcEmailAddress))
        //    {
        //        emailMessage.AddCc(new EmailAddress(contract.CcEmailAddress));
        //    }

        //    return ProcessResponse(_client.SendEmailAsync(emailMessage).Result);
        //}

        public EmailResponse SendContact(ContactViewModel contract)
        {
            var emailMessage = new SendGridMessage()
            {

                From = new EmailAddress(contract.FromEmailAddress, contract.Alias),
                Subject = contract.Subject,
                HtmlContent = contract.Body
            };

            emailMessage.AddTo(new EmailAddress("davedubois@animalrescuesystem.org"));
            if (!string.IsNullOrWhiteSpace(contract.BccEmailAddress))
            {
                emailMessage.AddBcc(new EmailAddress(contract.BccEmailAddress));
            }

            if (!string.IsNullOrWhiteSpace(contract.CcEmailAddress))
            {
                emailMessage.AddCc(new EmailAddress(contract.CcEmailAddress));
            }
            return ProcessResponse(_client.SendEmailAsync(emailMessage).Result);
        }

       

        public EmailResponse SendRegister(RegisterViewModel model)
        {
            var emailMessage = new SendGridMessage()
            {

                From = new EmailAddress(model.Email),
                Subject = "New Registration",
                HtmlContent = "This user <br />" + model.Email + "<span> of: <span /> <br />" +  model.Address + "<br /> has just registered on the site"
            };

            emailMessage.AddTo(new EmailAddress("davedubois@animalrescuesystem.org"));

            return ProcessResponse(_client.SendEmailAsync(emailMessage).Result);
        }

        

        private EmailResponse ProcessResponse(Response response)
        {
            if (response.StatusCode.Equals(System.Net.HttpStatusCode.Accepted)
                || response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                return ToMailResponse(response);
            }

            //TODO check for null
            var errorResponse = response.Body.ReadAsStringAsync().Result;

            throw new EmailServiceException(response.StatusCode.ToString(), errorResponse);
        }

        private static EmailResponse ToMailResponse(Response response)
        {
            if (response == null)
                return null;

            var headers = (HttpHeaders)response.Headers;
            var messageId = headers.GetValues(MessageId).FirstOrDefault();
            return new EmailResponse()
            {
                UniqueMessageId = messageId,
                DateSent = DateTime.UtcNow,
            };
        }

        public EmailResponse Sendconfirmation(RegisterViewModel model)
        {
            
            var emailMessage = new SendGridMessage()
            

            {

                Subject = "Thank you for registering",
                From = new EmailAddress("info@animalrescuesystem.org"),
                HtmlContent = "You will recieve an email shortly with details of your access level!",

            };

            emailMessage.AddTo(new EmailAddress(model.Email));

            return ProcessResponse(_client.SendEmailAsync(emailMessage).Result);
        }

        public HttpRequestBase Request { get; }
        public dynamic ViewBag { get; }

        public UrlHelper Url { get; set; }
        public async Task SendConfirmationMessage(RegisterViewModel model)
        {
            var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
            user.Address = model.Address;
            user.City = model.City;
            user.County = model.County;
            user.PostCode = model.PostCode;

            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var code = await userManager.GenerateEmailConfirmationTokenAsync(user.Id);
                var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                await userManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");
                ViewBag.Link = callbackUrl;
            }

            //var apiKey = ConfigurationManager.AppSettings["SendGridApiKey"];
            //var client = new SendGridClient(apiKey);
            //var msg = new SendGridMessage()
            //{
                
            //    ReplyTo = new EmailAddress(email),
            //    From = new EmailAddress("info@mycompany.com", "DX Team"),
            //    Subject = "Please confirm your email",
            //    PlainTextContent = callbackUrl,
            //    HtmlContent = callbackUrl
            //};

            //var response = await client.SendEmailAsync(msg);

        }

       
    }
}
