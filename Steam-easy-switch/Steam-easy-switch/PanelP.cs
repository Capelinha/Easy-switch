using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_easy_switch
{
    class PanelP : Panel
    {
        public long id64 { get; set; }

        public class HoverEventArgs
        {
            public bool Active { get; set; }

            public HoverEventArgs(bool active)
            {
                Active = active;
            }
        }

        public event EventHandler<HoverEventArgs> Hover;

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            OnHover(true);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
                return;
            else
            {
                base.OnMouseLeave(e);
                OnHover(false);
            }
        }

        protected void OnHover(bool active)
        {
            EventHandler<HoverEventArgs> hover = Hover;
            if (hover != null) hover(this, new HoverEventArgs(active));
        }
    }
}
