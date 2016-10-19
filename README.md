# HQF.WPF.OverLay
Test WPF Custom Control

Here is a bug,I have post it on [stackoverFlow.com](http://stackoverflow.com/questions/40106508/fired-datatrigger-is-not-changing-custom-controls-propertycontroltemplate)

**DataTrigger can't Set the MessageTemplate DepencyProperty.**

I found Some reason from [here](http://wpftutorial.net/templates.html)

>#Triggers

>`{RelativeSource TemplatedParent}` not working in DataTriggers of a ControlTemplate

>If you want to bind to a property of a property on your control like Data.IsLoaded you cannot use a normal Trigger, since it does not support this notation, you have to use a DataTrigger.

>But when you are using a DataTrigger, with {RelativeSource TemplatedParent} it will not work. The reason is, that **TemplatedParent can only be used within the ControlTemplate**. It is not working in the Trigger section. You have to use the {RelativeSource Self} instead.

>##What if a Binding working or a Setter is not applied when using a control template

>There is something you need to know when setting a value of an element within a control template: The value does have a lower precendence as the local value! So if you are setting the local value in the constructor of the contained element, you cannot override it within the controltemplate. But if you use the element directly in your view, it will work. So be aware of this behavior!.


###Reference
- [When should I use FrameworkPropertyMetadata or UIPropertyMetadata over plain PropertyMetadata?](http://stackoverflow.com/questions/2486999/when-should-i-use-frameworkpropertymetadata-or-uipropertymetadata-over-plain-pro)
- [Why dependency properties need a wrapper](https://blogs.msdn.microsoft.com/flaviencharlon/2012/12/06/why-dependency-properties-need-a-wrapper/)
- [WPF Adorners Part 4 – Simple and Powerful System for Using Adorners](http://www.nbdtech.com/Blog/archive/2010/07/12/wpf-adorners-part-4-ndash-simple-and-powerful-system-for.aspx)
- [BusyIndicator](https://wpftoolkit.codeplex.com/SourceControl/latest#Main/Source/ExtendedWPFToolkitSolution/Src/Xceed.Wpf.Toolkit/BusyIndicator/Implementation/BusyIndicator.cs)
- [Generic DataTemplateSelector](https://ovpwp.wordpress.com/2009/01/22/generic-datatemplateselector/)
