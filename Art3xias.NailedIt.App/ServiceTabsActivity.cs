using Android.App;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Art3xias.NailedIt.App.Adapters;

namespace Art3xias.NailedIt.App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class ServiceTabsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_service_tabs);

            ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.serviceTypePager);

            ServiceCategoryTypeFragmentAdapter serviceTypeFragmentAdapter =
                new ServiceCategoryTypeFragmentAdapter(SupportFragmentManager);

            viewPager.Adapter = serviceTypeFragmentAdapter;
        }
    }
}