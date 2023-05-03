﻿// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System;
using System.Net.Http;
using System.Xml.Linq;
using RESTFulSense.Brokers.MultipartFormDataContents;

namespace RESTFulSense.Services.Foundations.Forms
{
    internal class FormService : IFormService
    {
        private readonly IMultipartFormDataContentBroker multipartFormDataContentBroker;

        public FormService(IMultipartFormDataContentBroker multipartFormDataContentBroker) =>
            this.multipartFormDataContentBroker = multipartFormDataContentBroker;

        public MultipartFormDataContent AddByteArrayContent(
            MultipartFormDataContent multipartFormDataContent,
            byte[] content,
            string name)
        {
            MultipartFormDataContent returnedMultipartFormDataContent =
                this.multipartFormDataContentBroker
                    .AddByteArrayContent(multipartFormDataContent, content, name);

            return returnedMultipartFormDataContent;
        }

        public MultipartFormDataContent AddByteArrayContent(
            MultipartFormDataContent multipartFormDataContent,
            byte[] content,
            string name,
            string fileName) =>
            throw new NotImplementedException();
    }
}
