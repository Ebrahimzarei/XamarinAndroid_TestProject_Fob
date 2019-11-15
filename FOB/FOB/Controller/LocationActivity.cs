using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using FOB.Controller.Utility;

namespace FOB.Controller
{
    [Activity(Label = "LocationActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class LocationActivity : AppCompatActivity, IOnMapReadyCallback,ILocationListener
    {
        
        TextView location_TxtView_Header;
        Button location_Button_SetLocation;
        LocationManager locationManager;
        double _Lattiude;
        double _LongTiude;
        
        public void OnLocationChanged(Location location)
        {
            // زمانی که محل به روز شد
            _Lattiude = location.Latitude;
            _LongTiude = location.Longitude;
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            //LatLng location = _Lattiude==null && _LongTiude==null ? new LatLng(35.10418, -106.62987) : new LatLng(_Lattiude, _LongTiude);
            LatLng location =  new LatLng(_Lattiude, _LongTiude);
            CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
            builder.Target(location);
            builder.Zoom(18);
            builder.Bearing(155);
            builder.Tilt(65);

            CameraPosition cameraPosition = builder.Build();

            CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);

            googleMap.MoveCamera(cameraUpdate);




            //googleMap.MapType = GoogleMap.MapTypeTerrain;
            //googleMap.
            MarkerOptions markeroptions = new MarkerOptions();
            markeroptions.SetPosition(new LatLng(_Lattiude, _LongTiude));
            markeroptions.SetTitle("مکان من");
            googleMap.AddMarker(markeroptions);
            //optional
          //  googleMap.(18);
          //  googleMap.SetMinZoomPreference(18);


            //googleMap.UiSettings.ZoomControlsEnabled = true;
            //googleMap.UiSettings.CompassEnabled = true;
            //googleMap.MoveCamera(CameraUpdateFactory.ZoomIn());
        }

        public void OnProviderDisabled(string provider)
        {
            // زمانی که کاربرارائه دهنده را غیرفعال می کند
          
        }

        public void OnProviderEnabled(string provider)
        {
            // زمانی که کاربرارائه دهنده را فعال می کند
        }

        public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras)
        {
            // هنگامی که وضعیت ارائه دهنده تغییر می کند
        }
        protected override void OnPause()
        {
            base.OnPause();
            locationManager.RemoveUpdates(this);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
             locationManager = (LocationManager)GetSystemService(Context.LocationService);
            SetContentView(Resource.Layout.activity_location);
            location_TxtView_Header = FindViewById<TextView>(Resource.Id.location_TxtView_Header);
            location_TxtView_Header.Text = "تعیین موقعیت";
            location_Button_SetLocation = FindViewById<Button>(Resource.Id.location_Button_SetLocation);
            MapFragment mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.Locatin_Fragment_map);
            MapIsActive Isactive = new MapIsActive(this);
            location_Button_SetLocation.Click += delegate {
                //تعیین موقعیت توسط گوگل
                locationManager.RequestLocationUpdates(LocationManager.GpsProvider, 1000, 1, this);
                mapFragment.GetMapAsync(this);

            };
       
           
            Criteria locationCriteria = new Criteria();
            locationCriteria.Accuracy = Accuracy.Coarse;
            locationCriteria.PowerRequirement = Power.Medium;
           

           var locationProvider = locationManager.GetBestProvider(locationCriteria, true);

            if (locationProvider != null)
            {
                locationManager.RequestLocationUpdates(locationProvider, 2000, 1, this);
                if (Isactive.IsGooglePlayServicesInstalled())
                {


                    mapFragment.GetMapAsync(this);
                }
                else
                {
                    Snackbar snackBar = Snackbar.Make(location_Button_SetLocation, "اجرای سرویس گوگل پلی به مشکل خورده است", Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                    {
                        Finish();
                    });

                    //set  action button text color 
                    snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                    snackBar.Show();

                }
            }
            else
            {
                // Log.Info(tag, "No location providers available");
                Snackbar snackBar = Snackbar.Make(location_Button_SetLocation, "مکان باب دستگاه مکانی را پیدا نکرد", Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                {
                    Finish();
                });

                //set  action button text color 
                snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                snackBar.Show();
            }




        }
    }
  
}