using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Uitls
{
    /// <summary>
    /// Shapes工具类
    /// </summary>
    public class ShapesUitls
    {
        #region 是否存在该Name的Shapes
        /// <summary>
        /// 是否存在该Name的Shapes
        /// </summary>
        /// <param name="slide"></param>
        /// <param name="strShapeName"></param>
        /// <returns></returns>
        public static bool IsExistedOfShape(Slide slide, string strShapeName)
        {
            bool blnExisted = false;
            IEnumerator etr = slide.Shapes.GetEnumerator();
            while (etr.MoveNext())
            {
                if (((Shape)etr.Current).Name.Equals(strShapeName))
                {
                    blnExisted = true;
                    break;
                }
            }
            return blnExisted;
        }
        #endregion
    }
}
