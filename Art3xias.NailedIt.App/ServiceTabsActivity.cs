using Android.App;
using Android.OS;
using Android.Support.V4.View;

namespace Art3xias.NailedIt.App
{
    [Activity(Label = "ServiceTabsActivity")]
    public class ServiceTabsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_service_tabs);

            ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.nailPager);
        }
    }
}