using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HQF.WPF.Controls
{
    [TemplatePart(Name = "Part_MessageControl", Type = typeof(Control))]
    public class MessageOverLay : ContentControl
    {
        static MessageOverLay()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MessageOverLay),
                new FrameworkPropertyMetadata(typeof(MessageOverLay)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        #region DependcyProperties

        // Template attached property

        public static readonly DependencyProperty MessageTemplateProperty =
            DependencyProperty.Register("MessageTemplate", typeof(ControlTemplate), typeof(MessageOverLay),
                new FrameworkPropertyMetadata(MessageTemplateChanged));

        public static void SetMessageTemplate(DependencyObject dependencyObject, ControlTemplate value)
        {
            dependencyObject.SetValue(MessageTemplateProperty, value);
        }

        public static ControlTemplate GetMessageTemplate(DependencyObject dependencyObject)
        {
            return (ControlTemplate)dependencyObject.GetValue(MessageTemplateProperty);
        }

        private static void MessageTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //UpdateAdroner((UIElement) d, GetIsShowMessage((UIElement) d), (ControlTemplate) e.NewValue);
        }

        // IsVisible attached property

        public static readonly DependencyProperty IsShowMessageProperty =
            DependencyProperty.Register("IsShowMessage", typeof(bool), typeof(MessageOverLay),
                new PropertyMetadata(IsShowMessageChanged));

        public static bool GetIsShowMessage(UIElement target)
        {
            return (bool)target.GetValue(IsShowMessageProperty);
        }

        public static void SetIsShowMessage(UIElement target, bool value)
        {
            target.SetValue(IsShowMessageProperty, value);
        }

        private static void IsShowMessageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //UpdateAdroner((UIElement) d, (bool) e.NewValue, GetMessageTemplate((UIElement) d));
        }

       

       

        #endregion DependcyProperties

        public ControlTemplate MessageTemplate
        {
            get { return (ControlTemplate)GetValue(IsShowMessageProperty); }
            set { SetValue(MessageTemplateProperty, value); }
        }


    }
}
