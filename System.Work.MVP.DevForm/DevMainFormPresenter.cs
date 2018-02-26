using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Work.MVP.Core;

namespace System.Work.MVP.DevModule
{
    public class DevMainFormPresenter : Presenter<IDevMainForm>
    {
        public DevMainFormPresenter(IDevMainForm view) : base(view)
        {
            View.Load += View_Load;
        }

        private void View_Load(object sender, EventArgs e)
        {
            View.Model = new DevMainFormVM();
        }
    }
}
