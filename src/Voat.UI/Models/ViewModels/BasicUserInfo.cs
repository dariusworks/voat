#region LICENSE

/*
    
    Copyright(c) Voat, Inc.

    This file is part of Voat.

    This source file is subject to version 3 of the GPL license,
    that is bundled with this package in the file LICENSE, and is
    available online at http://www.gnu.org/licenses/gpl-3.0.txt;
    you may not use this file except in compliance with the License.

    Software distributed under the License is distributed on an
    "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either express
    or implied. See the License for the specific language governing
    rights and limitations under the License.

    All Rights Reserved.

*/

#endregion LICENSE

using Voat.Utilities;

namespace Voat.Models.ViewModels
{

    //This class is used in username hover popup on UI
    public class BasicUserInfo
    {
        private string _bio = null;

        public string MemberSince { get; set; }
        public int Ccp { get; set; }
        public int Scp { get; set; }
        public string Bio {
            get { return _bio; }
            set {
                if (value != STRINGS.DEFAULT_BIO)
                {
                    _bio = value;
                }
            }
        }
    }
}
