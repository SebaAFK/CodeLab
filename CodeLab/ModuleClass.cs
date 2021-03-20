using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab
{
    public static class ModuleClass
    {
        private static BalloonTip tooltipshow = new BalloonTip();
        public static bool ShowMessage(Image image , string textMessage, Control control)
        {
            tooltipshow.CloseBalloon();
            tooltipshow.RemoveAll();
            if (!(image is null))
            {
                tooltipshow.CaptionImage = image;
            }
            tooltipshow.SetBalloonText(control, textMessage);
            tooltipshow.ShowBalloonOnFocus = true;
            tooltipshow.ShowBalloon(control);
            tooltipshow.RemoveAll();
            try
            {
                control.Focus();
            }
            catch
            {
            }
            return true;
        }
    }
}
