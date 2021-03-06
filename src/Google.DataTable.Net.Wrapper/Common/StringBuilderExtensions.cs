﻿/*
   Copyright 2012 Zoran Maksimovic

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System.Text;

namespace Google.DataTable.Net.Wrapper.Common
{
    internal static class StringBuilderExtensions
    {
        public static bool AppendIfNotNull(this StringBuilder sb, string property, string text)
        {
            if (text != null)
            {
                sb.Append(string.Format("\"{0}\": \"{1}\", ", property, text));
                return true;
            }
            return false;
        }

        public static bool AppendIfNotNullOrEmpty(this StringBuilder sb, string property, string text, bool addBrackets)
        {
            if (!string.IsNullOrEmpty(text))
            {
                if (addBrackets)
                {
                    sb.Append(string.Format("\"{0}\":{{{1}}}, ", property, text));
                }
                else
                {
                    sb.Append(string.Format("\"{0}\": \"{1}\", ", property, text));
                }
                return true;
            }
            //else
            //{
            //    if (text == null)
            //    {
            //        if (addBrackets)
            //        {
            //            sb.Append(string.Format("{0}:{{null}}, ", Helper.DoubleQuoteString(property.ToLower())));
            //        }
            //        else
            //        {
            //            sb.Append(string.Format("{0}: null, ", Helper.DoubleQuoteString(property.ToLower())));
            //        }
            //        return true;
            //    }
            //}
            return false;
           
        }

        public static bool AppendIfNotNullOrEmpty(this StringBuilder sb, string property, string text)
        {
            return AppendIfNotNullOrEmpty(sb, property, text, false);
        }
    }
}