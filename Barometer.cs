namespace WeatherStationV10
{
    /// <summary>
    ///  Simple barometer, measuring pressure in hPa (hectopascal)
    /// </summary>
    public class Barometer
    {
        #region Instance fields
        private double _pressureInHPa;
        #endregion

        #region Constructor
        public Barometer()
        {
            _pressureInHPa = 1000.0;
        }
        #endregion

        #region Properties
        public double Pressure
        {
            get { return _pressureInHPa; }
            set { _pressureInHPa = value; }
        }

        public string WeatherDescription
        {
            get { if (_pressureInHPa < 980)
            { return "The weather is Stormy";}
            else if ( _pressureInHPa >= 980 && _pressureInHPa < 1000)
            {return "The weather is Rainy";}
            else if (_pressureInHPa >= 1000 && _pressureInHPa < 1020)
            {return "The weather is Changing";}
            else if (_pressureInHPa >= 1020 && _pressureInHPa < 1040)
            {return "The weather is Fair";}
            else 
            {return "The weather is Very Dry";}
            ; }
        }
        #endregion
    }
}