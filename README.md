Xamari.Forms.Plugin.RoundedFrameUWP!
===================


Frame for UWP with cornerRadius.

Install on PCL and  UWP projects.

For Android and IOS is not necessary;

## NuGet
* Available on NuGet: [Xamarin.Plugin.RoundedFrameUWP](https://www.nuget.org/packages/Xamarin.Forms.Plugin.RoundedFrame/)


----------


Properties
-------------


> - RoundedStyle : define style for rounded corners. {Full,Top,Down} 
> - BackgroundColor : Color for RoundedFrame.
> - CornerRadius = default is 15

How use it
-------------

##xaml ##

> Import : `xmlns:control="clr-namespace:RoundedFrameUWP;assembly=RoundedFrameUWP"`

> Use it : 

    <ContentPage.Content>
        <control:RoundedFrame BackgroundColor="Gray">
            <Label Text="Rounded Frame for UWP" HorizontalOptions="Center"VerticalOptions="Center"/>
        </control:RoundedFrame>
    </ContentPage.Content>

![Sample](https://imgur.com/a/43It4)
