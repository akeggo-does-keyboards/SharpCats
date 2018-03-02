using System;

using UIKit;

namespace SharpCatsiOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.


            buttonAdd.TouchUpInside+= ButtonAdd_TouchUpInside1;
            buttonSubtract.TouchUpInside+= ButtonSubtract_TouchUpInside1;
            buttonMultiply.TouchUpInside+= ButtonMultiply_TouchUpInside;
            buttonDivide.TouchUpInside+= ButtonDivide_TouchUpInside;
        }

        void ButtonAdd_TouchUpInside1(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtbox1stnum.Text);
            float num2 = float.Parse(txtbox2ndnum.Text);

            float result = num1 + num2;

            labelReply.Text = result.ToString();
        }

        void ButtonSubtract_TouchUpInside1(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtbox1stnum.Text);
            float num2 = float.Parse(txtbox2ndnum.Text);

            float result = num1 - num2;

            labelReply.Text = result.ToString();
        }

        void ButtonMultiply_TouchUpInside(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtbox1stnum.Text);
            float num2 = float.Parse(txtbox2ndnum.Text);

            float result = num1 * num2;

            labelReply.Text = result.ToString();
        }

        void ButtonDivide_TouchUpInside(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtbox1stnum.Text);
            float num2 = float.Parse(txtbox2ndnum.Text);

            float result = num1 / num2;

            labelReply.Text = result.ToString();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
