using System;

using BetterCms.Core.DataContracts;
using BetterCms.Core.DataContracts.Enums;
using BetterCms.Core.Security;

using Devbridge.Platform.Core.Models;

namespace BetterCms.Module.Root.Models
{
    [Serializable]
    public class PageOption : EquatableEntity<PageOption>, IOption, IAccessSecuredObjectDependency
    {
        public virtual Page Page { get; set; }

        public virtual string Value { get; set; }

        public virtual string Key { get; set; }

        public virtual OptionType Type { get; set; }

        public virtual CustomOption CustomOption { get; set; }

        IAccessSecuredObject IAccessSecuredObjectDependency.SecuredObject
        {
            get
            {
                return Page;
            }
        }

        ICustomOption IOption.CustomOption
        {
            get
            {
                return CustomOption;
            }
            set
            {
                CustomOption = (CustomOption)value;
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}, Key: {1}, Value: {2}, Type: {3}", base.ToString(), Key, Value, Type);
        }
    }
}