using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qualnet.Web
{
    public static class ParentApplicationExtenstions
    {
        private const string _parentApplicationQueryParamName = "parentApplication";
        /// <summary>
        /// appends the existing "parentApplication" query string parameter to the url
        /// the parentApplication is a param that is set when the LoadoutPC shows specific qualnet pages in it's iframe
        /// </summary>
        /// <returns></returns>
        public static string AppendParentApplicationParam(this string url, Microsoft.AspNetCore.Http.HttpRequest request)
        {
            var parentApp = request.ParentApplicationValue();

            if (!string.IsNullOrEmpty(parentApp))
            {
                url = Microsoft.AspNetCore.WebUtilities.QueryHelpers.AddQueryString(url, name: _parentApplicationQueryParamName, value: parentApp);
            }
            return url;
        }

        public static string ParentApplicationValue(this Microsoft.AspNetCore.Http.HttpRequest request)
        {
            if (request.Query.ContainsKey(_parentApplicationQueryParamName))
            {
                return request.Query[_parentApplicationQueryParamName]; 
            }
            else
            {
                return null;
            }
        }

    }
}
