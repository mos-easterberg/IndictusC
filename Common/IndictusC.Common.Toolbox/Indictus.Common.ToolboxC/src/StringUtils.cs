
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace IndictusC.Common.Toolbox
{
    public class StringUtils : BaseUtils
    {

		//===============================================================================================
        public static ArrayList Split(string sInput, string sDelimiter)
        {
            ArrayList arr = new ArrayList();

            try
            {
                foreach (string s in sInput.Split(sDelimiter.ToCharArray()))
                {
                    arr.Add(s.Trim());
                }
            }
            catch (Exception ex) { throw ex; }
            
            return arr;
        }


		//===============================================================================================
		public static bool IsInArrayList(ArrayList arr1, ArrayList arr2, bool bCaseSensitive)
		{
			try
			{
				foreach (string s1 in arr1)
				{
					foreach (string s2 in arr1)
					{
						if (bCaseSensitive)
						{
							if (s1.Equals(s2)) { return true; }
						}
						else
						{
							if (s1.ToUpper().Equals(s2.ToUpper())) { return true; }
						}
					}
				}
			}
			catch (Exception ex) { throw ex; }

			return false;			
		}


		//===============================================================================================
		public static bool IsInList(List<string> list_1, List<string> list_2, bool bCaseSensitive)
		{
			try
			{
				foreach (string s1 in list_1)
				{
					foreach (string s2 in list_2)
					{
						if (bCaseSensitive)
						{
							if (s1.Equals(s2)) { return true; }
						}
						else
						{
							if (s1.ToUpper().Equals(s2.ToUpper())) { return true; }
						}
					}
				}
			}
			catch (Exception ex) { throw ex; }

			return false;
		}

	}
}
