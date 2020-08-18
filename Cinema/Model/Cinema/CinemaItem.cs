using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CinemaItem : AItem
    {
        #region private members

        /// <summary>
        /// the update flags
        /// </summary>
        /// <remarks>
        /// theses flags are necessary in case of update items from the import
        /// </remarks>
        private bool _nameIsUpdated;
        private bool _inseeAggloCodeIsUpdated;
        private bool _inseeAggloNameIsUpdated;
        private bool _inseeTownCodeIsUpdated;
        private bool _inseeTownNameIsUpdated;
        private bool _communalPopulationIsUpdated;
        private bool _cncCodeIsUpdated;
        private bool _regieCodeIsUpdated;
        private bool _regieNameIsUpdated;
        private bool _regionNameIsUpdated;
        private bool _chairsCountIsUpdated;
        private bool _roomsCountIsUpdated;
        private bool _aggloPopulationIsUpdated;
        private bool _adressIsUpdated;
        private bool _postalCodeIsUpdated;
        private bool _deliveryOfficeIsUpdated;
        private bool _ownerCircuitIsUpdated;
        private bool _multiplexIsUpdated;
        private bool _artAndEssaiIsUpdated;
        private bool _strateIsUpdated;
        private bool _fhmIsUpdated;

        #endregion

        #region constructors

        /// <summary>
        /// the constructor
        /// </summary>
        public CinemaItem()
        {
            // initializes the properties
            this.InitializeProperties();

            // initializes the update flags
            this.InitializeUpdateFlags();
        }

        /// <summary>
        /// the constructor
        /// </summary>
       /* public CinemaItem(cinemasCinema xmlCinema)
        {
            // initializes the data
            this.InitializeProperties();
            this.InitializeUpdateFlags();

            foreach (cinemasCinemaField field in xmlCinema.field)
            {
                switch (field.key)
                {
                    case "code_rentrak":
                        this.UpdateRentrakCode(field.value);
                        break;
                    case "code_rentrak_provisoire":
                        this.UpdateRentrakCode(field.value);
                        break;
                    case "libelle":
                        this.UpdateName(field.value, true);
                        break;
                    case "code_ville":
                        this.UpdateInseeTownCode(field.value, true);
                        break;
                    case "libelle_ville":
                        this.UpdateInseeTownName(field.value, true);
                        break;
                    case "pop_ville":
                        this.UpdateCommunalPopulation(field.value, true);
                        break;
                    case "code_agglo":
                        this.UpdateInseeAggloCode(field.value, true);
                        break;
                    case "libelle_agglo":
                        this.UpdateInseeAggloName(field.value, true);
                        break;
                    case "pop_agglo":
                        this.UpdateAggloPopulation(field.value, true);
                        break;
                    case "code_cnc":
                        this.UpdateCNCCode(field.value, true);
                        break;
                    case "code_regie":
                        this.UpdateRegieCode(field.value, true);
                        break;
                    case "libelle_regie":
                        this.UpdateRegieName(field.value, true);
                        break;
                    case "proprietaire_circuit":
                        this.UpdateOwnerCircuit(field.value, true);
                        break;
                    case "libelle_region":
                        this.UpdateRegionName(field.value, true);
                        break;
                    case "adresse":
                        this.UpdateAdress(field.value, true);
                        break;
                    case "code_postal":
                        this.UpdatePostalCode(field.value, true);
                        break;
                    case "bureau_distributeur":
                        this.UpdateDeliveryOffice(field.value, true);
                        break;
                    case "nb_fauteuils":
                        this.UpdateChairsCount(field.value, true);
                        break;
                    case "nb_salles":
                        this.UpdateRoomsCount(field.value, true);
                        break;
                    case "multiplex":
                        this.UpdateMultiplex(field.value, true);
                        break;
                    case "art_essai":
                        this.UpdateArtAndEssai(field.value, true);
                        break;
                    case "strate":
                        this.UpdateStrate(field.value, true);
                        break;
                    case "fhm":
                        this.UpdateFHM(field.value, true);
                        break;
                }
            }
        }*/

        #endregion

        #region public properties

        /// <summary>
        /// the Rentrak code
        /// </summary>
        public Int32 RentrakCode { get; set; }

        /// <summary>
        /// the cinema name
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// the cinema index from the cinema file
        /// </summary>
        public Int32 IndexFromCinema { get; set; }

        /// <summary>
        /// the cinema name from the cinema file
        /// </summary>
        public String NameFromCinema { get; set; }

        /// <summary>
        /// the cinema index from the cinema list file
        /// </summary>
        public Int32 IndexFromCinemaList { get; set; }

        /// <summary>
        /// the cinema name from the cinema list file
        /// </summary>
        public String NameFromCinemaList { get; set; }

        /// <summary>
        /// the INSEE town code
        /// </summary>
        public String InseeTownCode { get; set; }

        /// <summary>
        /// the INSEE town name
        /// </summary>
        public String InseeTownName { get; set; }

        /// <summary>
        /// the communal population
        /// </summary>
        public Int32 CommunalPopulation { get; set; }

        /// <summary>
        /// the INSEE agglo code
        /// </summary>
        public String InseeAggloCode { get; set; }

        /// <summary>
        /// the INSEE agglo name
        /// </summary>
        public String InseeAggloName { get; set; }

        /// <summary>
        /// the agglo population
        /// </summary>
        public Int32 AggloPopulation { get; set; }

        /// <summary>
        /// the CNC code
        /// </summary>
        public Int32 CNCCode { get; set; }

        /// <summary>
        /// the regie code
        /// </summary>
        public Int32 RegieCode { get; set; }

        /// <summary>
        /// the regie name
        /// </summary>
        public String RegieName { get; set; }

        /// <summary>
        /// the region name
        /// </summary>
        public String RegionName { get; set; }

        /// <summary>
        /// the owner / circuit
        /// </summary>
        public String OwnerCircuit { get; set; }

        /// <summary>
        /// the adress
        /// </summary>
        public String Adress { get; set; }

        /// <summary>
        /// the postal code
        /// </summary>
        public Int32 PostalCode { get; set; }

        /// <summary>
        /// the delivery office
        /// </summary>
        public String DeliveryOffice { get; set; }

        /// <summary>
        /// the number of chairs
        /// </summary>
        public Double ChairsCount { get; set; }

        /// <summary>
        /// the number of rooms
        /// </summary>
        public Int32 RoomsCount { get; set; }

        /// <summary>
        /// the multiplex state
        /// </summary>
        public Int32 Multiplex { get; set; }

        /// <summary>
        /// the 'art & essai' state
        /// </summary>
        public Int32 ArtAndEssai { get; set; }

        /// <summary>
        /// the strate
        /// </summary>
        public Int32 Strate { get; set; }

        /// <summary>
        /// the FHM
        /// </summary>
        public Int32 FHM { get; set; }

        /// <summary>
        /// the unknow parameter 1 from the cinema file
        /// </summary>
        public String UnknowParameter1FromCinema { get; set; }

        /// <summary>
        /// the unknow parameter 1 from the cinema list file
        /// </summary>
        public String UnknowParameter1FromCinemaList { get; set; }

        /// <summary>
        /// the unknow parameter 2 from the cinema list file
        /// </summary>
        public String UnknowParameter2FromCinemaList { get; set; }

        /// <summary>
        /// the unknow parameter 3 from the cinema list file
        /// </summary>
        public String UnknowParameter3FromCinemaList { get; set; }

        /// <summary>
        /// the unknow parameter 4 from the cinema list file
        /// </summary>
        public String UnknowParameter4FromCinemaList { get; set; }

        /// <summary>
        /// the unknow parameter 5 from the cinema list file
        /// </summary>
        public String UnknowParameter5FromCinemaList { get; set; }

        /// <summary>
        /// the unknow parameter 6 from the cinema list file
        /// </summary>
        public String UnknowParameter6FromCinemaList { get; set; }

        /// <summary>
        /// the validity state
        /// </summary>
        public bool IsValid() { return this.RentrakCode > 0; }

        /// <summary>
        /// the cinema is in the parc file
        /// </summary>
        public bool IsInParc { get; set; }

        /// <summary>
        /// the cinema is in the cinemas file
        /// </summary>
        public bool IsInCinemas { get; set; }

        /// <summary>
        /// the cinema is in the cinemas list file
        /// </summary>
        public bool IsInCinemasList { get; set; }

        #endregion

        #region initialization

        /// <summary>
        /// initializes the properties
        /// </summary>
        private void InitializeProperties()
        {
            this.CommunalPopulation = -1;
            this.AggloPopulation = -1;
            this.CNCCode = -1;
            this.RegieCode = -1;
            this.PostalCode = -1;
            this.ChairsCount = -1;
            this.RoomsCount = -1;
            this.Multiplex = -1;
            this.ArtAndEssai = -1;
            this.Strate = -1;
            this.FHM = -1;

            this.IsInParc = false;
            this.IsInCinemas = false;
            this.IsInCinemasList = false;
        }

        /// <summary>
        /// initializes the update flags
        /// </summary>
        private void InitializeUpdateFlags()
        {
            this._nameIsUpdated = false;
            this._inseeAggloCodeIsUpdated = false;
            this._inseeAggloNameIsUpdated = false;
            this._inseeTownCodeIsUpdated = false;
            this._inseeTownNameIsUpdated = false;
            this._communalPopulationIsUpdated = false;
            this._cncCodeIsUpdated = false;
            this._regieCodeIsUpdated = false;
            this._regieNameIsUpdated = false;
            this._regionNameIsUpdated = false;
            this._chairsCountIsUpdated = false;
            this._roomsCountIsUpdated = false;
            this._aggloPopulationIsUpdated = false;
            this._adressIsUpdated = false;
            this._postalCodeIsUpdated = false;
            this._deliveryOfficeIsUpdated = false;
            this._ownerCircuitIsUpdated = false;
            this._multiplexIsUpdated = false;
            this._artAndEssaiIsUpdated = false;
            this._strateIsUpdated = false;
            this._fhmIsUpdated = false;
        }

        #endregion

        #region data update

        /// <summary>
        /// updates the rentrak code
        /// </summary>
        /// <param name="value">the string value</param>
        /// <returns>the validity</returns>
        private bool UpdateRentrakCode(String value)
        {
            // rentrak code
            Int32 l_int32Value = 0;
            if (!Int32.TryParse(value, out l_int32Value))
                return false;
            this.RentrakCode = l_int32Value;
            return true;
        }

        /// <summary>
        /// updates the name
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateName(String value, bool _updateFlag = false)
        {
            if (String.IsNullOrEmpty(value))
                return false;
            this.Name = value;
            this.NameFromCinema = value;
            this.NameFromCinemaList = value;
            if (_updateFlag)
                this._nameIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the Insee town code
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateInseeTownCode(String value, bool _updateFlag = false)
        {
            this.InseeTownCode = value;
            if (_updateFlag)
                this._inseeTownCodeIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the Insee town name
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateInseeTownName(String value, bool _updateFlag = false)
        {
            this.InseeTownName = value;
            if (_updateFlag)
                this._inseeTownNameIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the communal population
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateCommunalPopulation(String value, bool _updateFlag = false)
        {
            if (!String.IsNullOrEmpty(value))
            {
                Int32 l_int32Value = 0;
                if (!Int32.TryParse(value, out l_int32Value))
                    return false;
                this.CommunalPopulation = l_int32Value;
            }
            if (_updateFlag)
                this._communalPopulationIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the Insee agglo code
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateInseeAggloCode(String value, bool _updateFlag = false)
        {
            this.InseeAggloCode = value;
            if (_updateFlag)
                this._inseeAggloCodeIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the Insee agglo name
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateInseeAggloName(String value, bool _updateFlag = false)
        {
            this.InseeAggloName = value;
            if (_updateFlag)
                this._inseeAggloNameIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the agglo population
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateAggloPopulation(String value, bool _updateFlag = false)
        {
            if (!String.IsNullOrEmpty(value))
            {
                Int32 l_int32Value = 0;
                if (!Int32.TryParse(value, out l_int32Value))
                    return false;
                this.AggloPopulation = l_int32Value;
            }
            if (_updateFlag)
                this._aggloPopulationIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the CNC code
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateCNCCode(String value, bool _updateFlag = false)
        {
            if (!String.IsNullOrEmpty(value))
            {
                Int32 l_int32Value = 0;
                if (!Int32.TryParse(value, out l_int32Value))
                    return false;
                this.CNCCode = l_int32Value;
            }
            if (_updateFlag)
                this._cncCodeIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the regie code
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateRegieCode(String value, bool _updateFlag = false)
        {
            if (!String.IsNullOrEmpty(value))
            {
                Int32 l_int32Value = 0;
                if (!Int32.TryParse(value, out l_int32Value))
                    return false;
                this.RegieCode = l_int32Value;
            }
            if (_updateFlag)
                this._regieCodeIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the regie name
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateRegieName(String value, bool _updateFlag = false)
        {
            this.RegieName = value;
            if (_updateFlag)
                this._regieNameIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the owner / circuit
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateOwnerCircuit(String value, bool _updateFlag = false)
        {
            this.OwnerCircuit = value;
            if (_updateFlag)
                this._ownerCircuitIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the region name
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateRegionName(String value, bool _updateFlag = false)
        {
            this.RegionName = value;
            if (_updateFlag)
                this._regionNameIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the adress
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateAdress(String value, bool _updateFlag = false)
        {
            this.Adress = value;
            if (_updateFlag)
                this._adressIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the postal code
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdatePostalCode(String value, bool _updateFlag = false)
        {
            if (!String.IsNullOrEmpty(value))
            {
                Int32 l_int32Value = 0;
                if (!Int32.TryParse(value, out l_int32Value))
                    return false;
                this.PostalCode = l_int32Value;
            }
            if (_updateFlag)
                this._postalCodeIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the delivery office
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateDeliveryOffice(String value, bool _updateFlag = false)
        {
            this.DeliveryOffice = value;
            if (_updateFlag)
                this._deliveryOfficeIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the chairs count
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateChairsCount(String value, bool _updateFlag = false)
        {
            if (!String.IsNullOrEmpty(value))
            {
                Double l_doubleValue = 0.0;
                if (!Double.TryParse(value, out l_doubleValue))
                    return false;
                this.ChairsCount = l_doubleValue;
            }
            if (_updateFlag)
                this._chairsCountIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the rooms count
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateRoomsCount(String value, bool _updateFlag = false)
        {
            if (!String.IsNullOrEmpty(value))
            {
                Int32 l_int32Value = 0;
                if (!Int32.TryParse(value, out l_int32Value))
                    return false;
                this.RoomsCount = l_int32Value;
            }
            if (_updateFlag)
                this._roomsCountIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the multiplex state
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateMultiplex(String value, bool _updateFlag = false)
        {
            Int32 l_int32Value = 0;
            if (!String.IsNullOrEmpty(value) && Int32.TryParse(value, out l_int32Value))
                this.Multiplex = l_int32Value;
            if (_updateFlag)
                this._multiplexIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the art and essai state
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateArtAndEssai(String value, bool _updateFlag = false)
        {
            Int32 l_int32Value = 0;
            if (!String.IsNullOrEmpty(value) && Int32.TryParse(value, out l_int32Value))
                this.ArtAndEssai = l_int32Value;
            if (_updateFlag)
                this._artAndEssaiIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the strate
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateStrate(String value, bool _updateFlag = false)
        {
            if (!String.IsNullOrEmpty(value))
            {
                Int32 l_int32Value = 0;
                if (!Int32.TryParse(value, out l_int32Value))
                    return false;
                this.Strate = l_int32Value;
            }
            if (_updateFlag)
                this._strateIsUpdated = true;
            return true;
        }

        /// <summary>
        /// updates the FHM
        /// </summary>
        /// <param name="value">the string value</param>
        /// <param name="_updateFlag">updated the flag ?</param>
        /// <returns>the validity</returns>
        private bool UpdateFHM(String value, bool _updateFlag = false)
        {
            if (!String.IsNullOrEmpty(value))
            {
                Int32 l_int32Value = 0;
                if (!Int32.TryParse(value, out l_int32Value))
                    return false;
                this.FHM = l_int32Value;
            }
            if (_updateFlag)
                this._fhmIsUpdated = true;
            return true;
        }

        #endregion

        #region load

        /// <summary>
        /// loads a cinema from the parc line
        /// </summary>
        /// <param name="line">the line</param>
        /// <returns>the validity</returns>
        public bool LoadFromParcLine(String[] line)
        {
            // 21 fields
            if (line.Length != 21)
                return false;

            // rentrak code
            if (!this.UpdateRentrakCode(line[0]))
                return false;

            // name
            if (!this.UpdateName(line[1]))
                return false;

            // INSEE town code
            if (!this.UpdateInseeTownCode(line[2]))
                return false;

            // INSEE town name
            if (!this.UpdateInseeTownName(line[3]))
                return false;

            // communal population
            if (!this.UpdateCommunalPopulation(line[4]))
                return false;

            // INSEE agglo code
            if (!this.UpdateInseeAggloCode(line[5]))
                return false;

            // INSEE agglo name
            if (!this.UpdateInseeAggloName(line[6]))
                return false;

            // agglo population
            if (!this.UpdateAggloPopulation(line[7]))
                return false;

            // CNC code
            if (!this.UpdateCNCCode(line[8]))
                return false;

            // regie code
            if (!this.UpdateRegieCode(line[9]))
                return false;

            // owner / circuit
            if (!this.UpdateOwnerCircuit(line[10]))
                return false;

            // regie name
            if (!this.UpdateRegieName(line[11]))
                return false;

            // region name
            if (!this.UpdateRegionName(line[12]))
                return false;

            // adress
            if (!this.UpdateAdress(line[13]))
                return false;

            // postal code
            if (!this.UpdatePostalCode(line[14]))
                return false;

            // delivery office
            if (!this.UpdateDeliveryOffice(line[15]))
                return false;

            // chairs count
            if (!this.UpdateChairsCount(line[16]))
                return false;

            // rooms count
            if (!this.UpdateRoomsCount(line[17]))
                return false;

            // multiplex state
            if (!this.UpdateMultiplex(line[18]))
                return false;

            // 'art & essai' state
            if (!this.UpdateArtAndEssai(line[19]))
                return false;

            // strate
            if (!this.UpdateStrate(line[20]))
                return false;

            this.IsInParc = true;

            return true;
        }

        #endregion

        #region update

        /// <summary>
        /// updates the cinema from a cinema file line
        /// </summary>
        /// <param name="line">the cinema line</param>
        /// <param name="index">the cinema index in the cinemas list file</param>
        /// <returns>the validity</returns>
        public bool UpdateFromCinemaLine(String[] line, Int32 index)
        {
            // at least 2 fields
            if (line.Length < 2)
                return false;

            // the index
            this.IndexFromCinema = index;

            // the name
            this.NameFromCinema = line[1];

            // FHM
            if (!this.UpdateFHM(line.Length >= 3 && !String.IsNullOrEmpty(line[2]) ? line[2] : null))
                return false;

            // unknow parameter
            if (line.Length < 4)
                this.UnknowParameter6FromCinemaList = String.Empty;
            else
                this.UnknowParameter6FromCinemaList = line[3];

            this.IsInCinemas = true;

            return true;
        }

        /// <summary>
        /// updates the cinemas list from a cinema file line
        /// </summary>
        /// <param name="line">the cinemas list line</param>
        /// <param name="index">the cinema index in the cinemas list file</param>
        /// <returns>the validity</returns>
        public bool UpdateFromCinemaListLine(String[] line, Int32 index)
        {
            // at least 2 fields
            if (line.Length < 2)
                return false;

            // the index
            this.IndexFromCinemaList = index;

            // the name
            this.NameFromCinemaList = line[1];

            // unknow parameter 1
            if (line.Length < 3)
                this.UnknowParameter1FromCinemaList = String.Empty;
            else
                this.UnknowParameter1FromCinemaList = line[2];

            // unknow parameter 2
            if (line.Length < 4)
                this.UnknowParameter2FromCinemaList = String.Empty;
            else
                this.UnknowParameter2FromCinemaList = line[3];

            // unknow parameter 3
            if (line.Length < 5)
                this.UnknowParameter3FromCinemaList = String.Empty;
            else
                this.UnknowParameter3FromCinemaList = line[4];

            // unknow parameter 4
            if (line.Length < 6)
                this.UnknowParameter4FromCinemaList = String.Empty;
            else
                this.UnknowParameter4FromCinemaList = line[5];

            // unknow parameter 5
            if (line.Length < 7)
                this.UnknowParameter5FromCinemaList = String.Empty;
            else
                this.UnknowParameter5FromCinemaList = line[6];

            // unknow parameter 6
            if (line.Length < 8)
                this.UnknowParameter6FromCinemaList = String.Empty;
            else
                this.UnknowParameter6FromCinemaList = line[7];

            this.IsInCinemasList = true;

            return true;
        }

        /// <summary>
        /// updates a cinema
        /// </summary>
        /// <param name="source">the source cinema</param>
        public void Update(CinemaItem source)
        {
            if (source == null)
                return;

            if (source._nameIsUpdated)
            {
                this.Name = source.Name;
                this.NameFromCinema = source.Name;
                this.NameFromCinemaList = source.Name;
            }
            if (source._inseeTownCodeIsUpdated)
                this.InseeTownCode = source.InseeTownCode;
            if (source._inseeTownNameIsUpdated)
                this.InseeTownName = source.InseeTownName;
            if (source._communalPopulationIsUpdated)
                this.CommunalPopulation = source.CommunalPopulation;
            if (source._inseeAggloCodeIsUpdated)
                this.InseeAggloCode = source.InseeAggloCode;
            if (source._inseeAggloNameIsUpdated)
                this.InseeAggloName = source.InseeAggloName;
            if (source._aggloPopulationIsUpdated)
                this.AggloPopulation = source.AggloPopulation;
            if (source._cncCodeIsUpdated)
                this.CNCCode = source.CNCCode;
            if (source._regieCodeIsUpdated)
                this.RegieCode = source.RegieCode;
            if (source._regieNameIsUpdated)
                this.RegieName = source.RegieName;
            if (source._ownerCircuitIsUpdated)
                this.OwnerCircuit = source.OwnerCircuit;
            if (source._regionNameIsUpdated)
                this.RegionName = source.RegionName;
            if (source._adressIsUpdated)
                this.Adress = source.Adress;
            if (source._postalCodeIsUpdated)
                this.PostalCode = source.PostalCode;
            if (source._deliveryOfficeIsUpdated)
                this.DeliveryOffice = source.DeliveryOffice;
            if (source._chairsCountIsUpdated)
                this.ChairsCount = source.ChairsCount;
            if (source._roomsCountIsUpdated)
                this.RoomsCount = source.RoomsCount;
            if (source._multiplexIsUpdated)
                this.Multiplex = source.Multiplex;
            if (source._artAndEssaiIsUpdated)
                this.ArtAndEssai = source.ArtAndEssai;
            if (source._strateIsUpdated)
                this.Strate = source.Strate;
            if (source._fhmIsUpdated)
                this.FHM = source.FHM;
        }

        #endregion

        #region csv

        /// <summary>
        /// the conversion to csv line for the parc file
        /// </summary>
        public String ToParcCsvLine()
        {
            return String.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14};{15};{16};{17};{18};{19};{20}",
                this.RentrakCode,
                this.Name.Trim(),
                this.InseeTownCode,
                this.InseeTownName.Trim(),
                this.CommunalPopulation >= 0 ? this.CommunalPopulation.ToString() : String.Empty,
                this.InseeAggloCode,
                this.InseeAggloName.Trim(),
                this.AggloPopulation >= 0 ? this.AggloPopulation.ToString() : String.Empty,
                this.CNCCode >= 0 ? this.CNCCode.ToString() : String.Empty,
                this.RegieCode >= 0 ? this.RegieCode.ToString() : String.Empty,
                this.OwnerCircuit.Trim(),
                this.RegieName.Trim(),
                this.RegionName.Trim(),
                this.Adress.Trim(),
                this.PostalCode >= 0 ? this.PostalCode.ToString() : String.Empty,
                this.DeliveryOffice.Trim(),
                this.ChairsCount >= 0.0 ? this.ChairsCount.ToString() : String.Empty,
                this.RoomsCount >= 0 ? this.RoomsCount.ToString() : String.Empty,
                this.Multiplex >= 0 ? this.Multiplex.ToString() : String.Empty,
                this.ArtAndEssai >= 0 ? this.ArtAndEssai.ToString() : String.Empty,
                this.Strate >= 0 ? this.Strate.ToString() : String.Empty
                );
        }

        /// <summary>
        /// the conversion to csv line for the cinema file
        /// </summary>
        public String ToCinemaCsvLine()
        {
            return String.Format("{0};{1};{2};{3}", this.RentrakCode, this.NameFromCinema.Trim(), this.FHM >= 0 ? this.FHM.ToString() : String.Empty, this.UnknowParameter1FromCinema);
        }

        /// <summary>
        /// the conversion to csv line for the cinema list file
        /// </summary>
        public String ToCinemaListCsvLine()
        {
            return String.Format("{0};{1};{2};{3};{4};{5};{6};{7}", this.RentrakCode, this.NameFromCinemaList.Trim(), this.UnknowParameter1FromCinemaList, this.UnknowParameter2FromCinemaList, this.UnknowParameter3FromCinemaList, this.UnknowParameter4FromCinemaList, this.UnknowParameter5FromCinemaList, this.UnknowParameter6FromCinemaList);
        }

        #endregion
    }
}
