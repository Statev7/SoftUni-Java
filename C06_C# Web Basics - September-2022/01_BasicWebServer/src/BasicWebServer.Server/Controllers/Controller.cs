﻿namespace BasicWebServer.Controllers
{
    using BasicWebServer.HTTP;
    using BasicWebServer.HTTP.Cookies;
    using BasicWebServer.Responses.ActionResponses;
    using BasicWebServer.Responses.ContentResponses;

    public abstract class Controller
    {
        protected Controller(Request request)
        {
            this.Request = request;
        }

        protected Request Request { get; private init; }

        protected Response Text(string text) => new TextResponse(text);

        protected Response Html(string text, CookieCollection cookies = null)
        {
            HtmlResponse response = new HtmlResponse(text);

            if (cookies != null)
            {
                foreach (var cookie in cookies)
                {
                    response.Cookies.Add(cookie.Name, cookie.Value);
                }
            }

            return response;
        }

        protected Response Redirect(string location) => new RedirectResponse(location);

        protected Response File(string fileName) => new TextFileResponse(fileName);

        protected Response BadRequest() => new BadRequestResponse();

        protected Response Unauthorized() => new UnauthorizedResponse();

        protected Response NotFound() => new NotFoundResponse();
    }
}
