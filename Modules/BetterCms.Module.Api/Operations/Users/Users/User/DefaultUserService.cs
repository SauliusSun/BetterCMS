﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultUserService.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using BetterCms.Core.Exceptions;
using BetterCms.Module.Api.Operations.Users.Users.User.ValidateUser;

namespace BetterCms.Module.Api.Operations.Users.Users.User
{
    public class DefaultUserService : IUserService
    {
        private readonly IValidateUserService validateUserService;

        public DefaultUserService(IValidateUserService validateUserService)
        {
            this.validateUserService = validateUserService;
        }

        public GetUserResponse Get(GetUserRequest request)
        {
            throw new CmsException(UsersApiConstants.UsersApiHasNoImplementationMessage);
        }

        public DeleteUserResponse Delete(DeleteUserRequest request)
        {
            throw new CmsException(UsersApiConstants.UsersApiHasNoImplementationMessage);
        }

        public PutUserResponse Put(PutUserRequest request)
        {
            throw new CmsException(UsersApiConstants.UsersApiHasNoImplementationMessage);
        }

        ValidateUserResponse IUserService.Validate(ValidateUserRequest request)
        {
            return validateUserService.Get(request);
        }
    }
}