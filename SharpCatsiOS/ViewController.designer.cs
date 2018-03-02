// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace SharpCatsiOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonAdd { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDivide { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonMultiply { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonSubtract { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelReply { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtbox1stnum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtbox2ndnum { get; set; }

        [Action ("ButtonAdd_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ButtonAdd_TouchUpInside (UIKit.UIButton sender);

        [Action ("ButtonSubtract_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ButtonSubtract_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (buttonAdd != null) {
                buttonAdd.Dispose ();
                buttonAdd = null;
            }

            if (buttonDivide != null) {
                buttonDivide.Dispose ();
                buttonDivide = null;
            }

            if (buttonMultiply != null) {
                buttonMultiply.Dispose ();
                buttonMultiply = null;
            }

            if (buttonSubtract != null) {
                buttonSubtract.Dispose ();
                buttonSubtract = null;
            }

            if (labelReply != null) {
                labelReply.Dispose ();
                labelReply = null;
            }

            if (txtbox1stnum != null) {
                txtbox1stnum.Dispose ();
                txtbox1stnum = null;
            }

            if (txtbox2ndnum != null) {
                txtbox2ndnum.Dispose ();
                txtbox2ndnum = null;
            }
        }
    }
}