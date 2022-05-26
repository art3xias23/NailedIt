using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace Art3xias.NailedIt.App
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : AppCompatActivity
    {
        private EditText _nameEditText;
        private EditText _mobileNumberEditText;
        private Button _loginContinueButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_login);
            AddEventHandlers();

            AssignAndSetControlContents();
            // Create your application here
        }

        private void AddEventHandlers()
        {
            _loginContinueButton.Click += _loginContinueButton_Click;
        }

        private void _loginContinueButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(ServiceTabsActivity));
            StartActivity(intent);
        }

        private void AssignAndSetControlContents()
        {
            var nameTextView = FindViewById<TextView>(Resource.Id.nameTextView).Text = "Име";
            var TextView=FindViewById<TextView>(Resource.Id.mobileNumberTextView).Text = "Телефон";

            _nameEditText = FindViewById<EditText>(Resource.Id.nameEditText);
            _mobileNumberEditText = FindViewById<EditText>(Resource.Id.mobileNumberEditText);
            _loginContinueButton = FindViewById<Button>(Resource.Id.loginContinueButton);
        }
    }
}