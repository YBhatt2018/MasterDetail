using System;
using System.Threading.Tasks;
using Xamarin.Forms;
[assembly: Xamarin.Forms.Dependency(typeof(ScreenshotManager))]
namespace MasterDetail
{
    public interface IScreenshotManager
    {
        Task<byte[]> CaptureAsync();
    }
}
