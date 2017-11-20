using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indictus.Common.ToolboxC
{
    class CollectionUtils
    {
    //    Public Shared Function TranslateDelimitedStringToCollection(ByVal sString As String, ByVal sDelimiter As String) As Collection

    //    Dim coll As Collection = Nothing

    //    Try
    //        coll = New Collection
    //        For Each s As String In Toolbox.StringUtils.Split(sString, sDelimiter)
    //            coll.Add(s)
    //        Next
    //    Catch ex As Exception
    //        Throw ex
    //    End Try

    //    Return coll

    //End Function

        public static ArrayList TranslateDelimitedStringToArrayList(string sString, string sDelimiter)
        {            
            ArrayList arr = new ArrayList();

            try
            {
            }
            catch (Exception ex) {
                throw ex;
            }

            return arr;
        }
    }
}
