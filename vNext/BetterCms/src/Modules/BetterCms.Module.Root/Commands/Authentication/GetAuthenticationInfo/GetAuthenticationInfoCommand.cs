﻿using System;

using BetterCms.Module.Root.Models.Authentication;
using BetterCms.Module.Root.Mvc;
using BetterCms.Module.Root.Services;
using BetterModules.Core.Infrastructure.Commands;

namespace BetterCms.Module.Root.Commands.Authentication.GetAuthenticationInfo
{
    public class GetAuthenticationInfoCommand : CommandBase, ICommandOut<InfoViewModel>
    {
        /// <summary>
        /// The URL resolver
        /// </summary>
        private readonly IUserProfileUrlResolver urlResolver;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthenticationInfoCommand" /> class.
        /// </summary>
        /// <param name="urlResolver">The URL resolver.</param>
        public GetAuthenticationInfoCommand(IUserProfileUrlResolver urlResolver)
        {
            this.urlResolver = urlResolver;
        }

        public InfoViewModel Execute()
        {
            var model = new InfoViewModel
            {
                IsUserAuthenticated = Context.Principal.Identity.IsAuthenticated,
                UserName = Context.Principal.Identity.Name,
                EditUserProfileUrl = urlResolver.GetEditUserProfileUrl()
            };

            return model;
        }
    }
}