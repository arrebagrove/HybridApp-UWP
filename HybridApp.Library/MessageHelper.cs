using System;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;
using Windows.UI.Popups;

namespace HybridApp.Library
{
    [AllowForWeb]
    public sealed class MessageHelper
    {
        public void ShowToastNotification()
        {
            var xml = @"<toast>
                            <visual>
                                <binding template='ToastGeneric'>
                                    <text>Hello world!</text>
                                    <text>This is a a notification</text>
                                </binding>
                            </visual>
                        </toast>";

            XmlDocument document = new XmlDocument();
            document.LoadXml(xml);
            ToastNotification notification = new ToastNotification(document);

            ToastNotifier notifier = ToastNotificationManager.CreateToastNotifier();
            notifier.Show(notification);
        }
    }
}
