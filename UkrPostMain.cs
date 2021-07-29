﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiUkrPost;
using ApiUkrPost.Adresses;
using ApiUkrPost.Base;
using PostAPI.UtilityClass;
using GemBox.Pdf;
using Newtonsoft.Json;
using Region = ApiUkrPost.Adresses.Region;

namespace PostAPI
{
    public partial class UkrPostMain : Form
    {
        private readonly User _user;
        private readonly Controller _controller;

        private const string SenderAddress = "188358418";
        private const string SenderUuid = "1bd2e07e-52a6-4eda-bd48-60624153d5d8";
        private const string AddressMy = "188510591";
        private const string UuidMy = "d13743c3-1803-4e6f-b48a-535e997494fa";

        private List<Region> _regions;
        private List<District> _districts;
        private List<City> _cities;
        private List<Street> _streets;
        private List<House> _houses;

        public AddressDto Address;
        public ClientDto Client;
        public ShipmentDto Shipment;

        public UkrPostMain()
        {
            InitializeComponent();
        }

        public UkrPostMain(User user, string server = "") : this()
        {
            _user = user;
            if (server == "Test")
            {
                _controller = new Controller(_user.AuthorizationBearer, _user.UserToken, "Test");
            }
            else
            {
                _controller = new Controller(_user.AuthorizationBearer, _user.UserToken);
            }
            _regions = Controller.GetRegions("");
            _cbRegion.Items.AddRange(_regions.Select(r => r.ToString()).ToArray());
            _cbRegion.SelectedIndex = 18;

            _cbClientType.Items.AddRange(Enum.GetValues(typeof(ClientIndivType)).Cast<ClientIndivType>().Select(c => c.ToString()).ToArray());
            _cbClientType.SelectedIndex = 0;

            _cbShipmentType.Items.AddRange(Enum.GetValues(typeof(ShipmentType)).Cast<ShipmentType>().Select(c => c.ToString()).ToArray());
            _cbShipmentType.SelectedIndex = 1;

            _cbDeliveryType.Items.AddRange(Enum.GetValues(typeof(DeliveryType)).Cast<DeliveryType>().Select(c => c.ToString()).ToArray());
            _cbDeliveryType.SelectedIndex = 0;

            _tbSender.Text = SenderUuid;
        }

        private void _bLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btGetIndex_Click(object sender, EventArgs e)
        {
            if (_cbDistrict.Text != "" && _cbCity.Text != "" && _cbStreet.Text != "" && _cbHouse.Text != "")
            {
                _tbPostCode.Text = _houses[_cbHouse.SelectedIndex].POSTCODE;

                Address = Controller.CreateAddress(_houses[_cbHouse.SelectedIndex].POSTCODE,
                                                          _regions[_cbRegion.SelectedIndex].ToString(),
                                                          _districts[_cbDistrict.SelectedIndex].ToString(),
                                                          _cities[_cbCity.SelectedIndex].ToString(),
                                                          _streets[_cbStreet.SelectedIndex].ToString(),
                                                          _houses[_cbHouse.SelectedIndex].HOUSENUMBERUA,
                                                          _tbApartment.Text.Trim());
                if (Address != null)
                {
                    _tbAddressId.Text = Address.id.ToString();
                    _tbClientAddressId.Text = Address.id.ToString();
                }
                else
                {
                    _tbAddressId.Text = "Не створено";
                }
            }
        }

        private void _btGetAddress_Click(object sender, EventArgs e)
        {
            if (_tbPostCode.Text.Trim() != "" && int.TryParse(_tbPostCode.Text.Trim(), out int index) && index != 0)
            {
                var city = Controller.GetCityByPostcode(index);
                if (city == null) return;

                var region = _regions.FindIndex(r => r.REGIONUA == city.REGIONUA);
                _cbRegion.SelectedIndex = region;

                _districts = Controller.GetDistricts(Convert.ToInt64(_regions[region].REGIONID), city.DISTRICTUA);
                if (_districts == null || _districts.Count == 0) return;
                _cbDistrict.Items.Clear();
                _cbDistrict.Items.AddRange(_districts.Select(d => d.ToString()).ToArray());
                _cbDistrict.SelectedIndex = 0;

                _cities = Controller.GetCities(Convert.ToInt64(_regions[region].REGIONID), Convert.ToInt64(_districts[0].DISTRICTID), city.CITYUA);
                if (_cities == null || _cities.Count == 0) return;
                _cbCity.Items.Clear();
                _cbCity.Items.AddRange(_cities.Select(d => d.ToString()).ToArray());
                _cbCity.SelectedIndex = 0;

                _streets = Controller.GetStreets(Convert.ToInt64(_regions[region].REGIONID), Convert.ToInt64(_districts[0].DISTRICTID), Convert.ToInt64(_cities[0].CITYID), "");
                if (_streets == null || _streets.Count == 0) return;
                _cbStreet.Items.Clear();
                _cbStreet.Items.AddRange(_streets.Select(d => d.ToString()).ToArray());
                _cbStreet.Text = "";
                _cbHouse.Text = "";
                _tbApartment.Text = "";

            }
        }

        private void _cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbDistrict.Items.Clear();
            _cbDistrict.Text = "";
            _cbCity.Text = "";
            _cbStreet.Text = "";
            _cbHouse.Text = "";
            _districts = Controller.GetDistricts(Convert.ToInt64(_regions[_cbRegion.SelectedIndex].REGIONID), "");
            _cbDistrict.Items.AddRange(_districts.Select(d => d.ToString()).ToArray());
        }

        private void _cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbCity.Items.Clear();
            _cbCity.Text = "";
            _cbStreet.Text = "";
            _cbHouse.Text = "";
            _cities = Controller.GetCities(Convert.ToInt64(_regions[_cbRegion.SelectedIndex].REGIONID), Convert.ToInt64(_districts[_cbDistrict.SelectedIndex].DISTRICTID), "");
            _cbCity.Items.AddRange(_cities.Select(d => d.ToString()).ToArray());
        }

        private void _cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbStreet.Items.Clear();
            _cbStreet.Text = "";
            _cbHouse.Text = "";
            _streets = Controller.GetStreets(Convert.ToInt64(_regions[_cbRegion.SelectedIndex].REGIONID), Convert.ToInt64(_districts[_cbDistrict.SelectedIndex].DISTRICTID), Convert.ToInt64(_cities[_cbCity.SelectedIndex].CITYID), "");
            _cbStreet.Items.AddRange(_streets.Select(d => d.ToString()).ToArray());
        }

        private void _cbStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbHouse.Items.Clear();
            _cbHouse.Text = "";
            _houses = Controller.GetHouses(Convert.ToInt64(_streets[_cbStreet.SelectedIndex].STREETID), "");
            _cbHouse.Items.AddRange(_houses.Select(d => d.ToString()).ToArray());
        }

        private void _btCreateClient_Click(object sender, EventArgs e)
        {
            if (_tbFirstName.Text.Trim() != "" && _tbLastName.Text.Trim() != "" && _tbClientAddressId.Text != "" && _tbPhone.Text.Trim() != "" && _cbClientType.Text != "")
            {
                Client = Controller.CreateClient(_tbFirstName.Text.Trim(), _tbLastName.Text.Trim(), _tbMiddleName.Text.Trim(), Convert.ToInt64(_tbClientAddressId.Text), _tbPhone.Text.Trim(), (ClientIndivType)_cbClientType.SelectedIndex);
                if (Client != null)
                {
                    _tbClientId.Text = Client.uuid.ToString();
                    _tbRecipient.Text = Client.uuid.ToString();
                }
                else
                {
                    _tbClientId.Text = "Не створено";
                }
            }
        }

        private void _btClientChange_Click(object sender, EventArgs e)
        {
            if (_tbClienеIdChange.Text.Trim() != "" && _tbFirstName.Text.Trim() != "" && _tbLastName.Text.Trim() != "" && _tbClientAddressId.Text != "" && _tbPhone.Text.Trim() != "" && _cbClientType.Text != "")
            {
                Client = _controller.ChangeClient(_tbClienеIdChange.Text.Trim(), _tbFirstName.Text.Trim(), _tbLastName.Text.Trim(), _tbMiddleName.Text.Trim(), Convert.ToInt64(_tbClientAddressId.Text), _tbPhone.Text.Trim(), (ClientIndivType)_cbClientType.SelectedIndex);
                if (Client == null)
                {
                    MessageBox.Show("Дані клієнта не змінені");
                }
                else
                {
                    MessageBox.Show("Дані клієнта змінені!!!");
                }
            }
        }

        private void _btGetClient_Click(object sender, EventArgs e)
        {
            if (_tbClienеIdChange.Text.Trim() != "")
            {
                Client = Controller.GetClient(_tbClienеIdChange.Text.Trim());
                if (Client == null)
                {
                    MessageBox.Show("Клієнта не знайдено!");
                }
                else
                {
                    _tbFirstName.Text = Client.firstName;
                    _tbLastName.Text = Client.lastName;
                    _tbMiddleName.Text = Client.middleName;
                    _tbClientAddressId.Text = Client.addressId.ToString();
                    _tbPhone.Text = Client.phoneNumber;
                    _cbClientType.Text = Client.type.ToString();
                }
            }
        }

        private void _btCreateShipment_Click(object sender, EventArgs e)
        {
            if (_tbSender.Text.Trim() != "" && _tbRecipient.Text.Trim() != "" && _cbShipmentType.Text != "" && _cbDeliveryType.Text != "" && int.TryParse(_tbWeight.Text.Trim(), out int weight) && int.TryParse(_tbLength.Text.Trim(), out int length))
            {
                // ДОРОБИТИ ІНШІ ПОЛЯ
                Shipment = Controller.CreateShipment(_tbSender.Text.Trim(), 
                                                     _tbRecipient.Text.Trim(), 
                                                     (DeliveryType)_cbDeliveryType.SelectedIndex, 
                                                     (ShipmentType)_cbShipmentType.SelectedIndex, 
                                                     weight, 
                                                     length, 
                                                     _tbWidth.Text.ParseNullableInt(), 
                                                     _tbHeight.Text.ParseNullableInt(), 
                                                     _tbDeclaredPrice.Text.ParseNullableInt());
                if (Shipment == null)
                {
                    MessageBox.Show("Відправлення не створено!");
                }
                else
                {
                    _tbShipmentUuid.Text = Shipment.uuid.ToString();
                }
            }
        }

        private void _btGetShipment_Click(object sender, EventArgs e)
        {
            if (_tbShipmentUuid.Text.Trim() != "")
            {
                Shipment = Controller.GetShipment(_tbShipmentUuid.Text.Trim());
                if (Shipment == null)
                {
                    MessageBox.Show("Відправлення не знайдено!");
                }
                else
                {
                    _tbSender.Text = Shipment.sender.uuid.ToString();
                    _tbRecipient.Text = Shipment.recipient.uuid.ToString();
                    _cbShipmentType.Text = Shipment.type.ToString();
                    _cbDeliveryType.Text = Shipment.deliveryType.ToString();
                    _tbWeight.Text = Shipment.parcels[0].weight.ToString();
                    _tbLength.Text = Shipment.parcels[0].length.ToString();
                }
            }
        }

        private void _btClients_Click(object sender, EventArgs e)
        {
            if (_tbPhoneClient.Text.Trim() != "")
            {
                var clients = Controller.GetClients(_tbPhoneClient.Text.Trim());
                //Controller.GetClientsXml(_user.AuthorizationBearer, _user.UserToken, _tbPhoneClient.Text.Trim(), out string result);
                if (clients == null)
                {
                    MessageBox.Show("Клієнтів не знайдено!");
                }
                else
                {
                    _dgvClients.DataSource = clients;
                    _dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
        }

        private void _btGetShipmentBySender_Click(object sender, EventArgs e)
        {
            if (_tbSenderAll.Text.Trim() != "")
            {
                var shipments = Controller.GetShipmentBySender(_tbSenderAll.Text.Trim());
                //Controller.GetShipmentBySenderXml(_user.AuthorizationBearer, _user.UserToken, _tbSenderAll.Text.Trim(), out string result);
                if (shipments == null)
                {
                    MessageBox.Show("Відправлення не знайдено!");
                }
                else
                {
                    _dgvShipments.DataSource = shipments.OrderBy(s => s.lastModified).ToList();
                    _dgvShipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
        }

        private void _btShipmentDelete_Click(object sender, EventArgs e)
        {
            if (_tbShipmentDelete.Text.Trim() != "")
            {
                var shipments = Controller.GetShipment(_tbShipmentDelete.Text.Trim());
                if (shipments == null)
                {
                    MessageBox.Show("Відправлення не знайдено!");
                }
                else
                {
                    if (Controller.DeleteShipment(_tbShipmentDelete.Text.Trim()))
                    {
                        MessageBox.Show("Відправлення видалено!");
                    }
                    else
                    {
                        MessageBox.Show("Відправлення не видалено!");
                    }
                }
            }
        }

        private void _btGetSticker_Click(object sender, EventArgs e)
        {
            var fileNameJPG = Path.GetTempPath() + @"UkrPost.jpg";
            try { if (File.Exists(fileNameJPG)) File.Delete(fileNameJPG); } catch { return; }

            var fileNamePDF = Controller.GetStickerFile(_tbShipmentUuid.Text.Trim());
            if (fileNamePDF == null) return;

            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            using (PdfDocument document = PdfDocument.Load(fileNamePDF))
            {
                document.Save(fileNameJPG);
            }

            pictureBox1.Image = Image.FromFile(fileNameJPG);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void _btSaveFile_Click(object sender, EventArgs e)
        {
            var fileNamePDF = Controller.GetStickerFile(_tbShipmentUuid.Text.Trim());
            if (fileNamePDF != null)
            {
                var saveFileDialog = new SaveFileDialog() { Filter = "PDF-files|*.pdf" };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(fileNamePDF, saveFileDialog.FileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_tbAddressId.Text.Trim() != "" && long.TryParse(_tbAddressId.Text.Trim(), out long id) && id != 0)
            {
                Address = Controller.GetAddressByID(id);
                if (Address == null) return;

                var region = _regions.FindIndex(r => r.REGIONUA == Address.region);
                _cbRegion.SelectedIndex = region;

                _districts = Controller.GetDistricts(Convert.ToInt64(_regions[region].REGIONID), Address.district);
                if (_districts == null || _districts.Count == 0) return;
                _cbDistrict.Items.Clear();
                _cbDistrict.Items.AddRange(_districts.Select(d => d.ToString()).ToArray());
                _cbDistrict.SelectedIndex = 0;

                _cities = Controller.GetCities(Convert.ToInt64(_regions[region].REGIONID), Convert.ToInt64(_districts[0].DISTRICTID), Address.city);
                if (_cities == null || _cities.Count == 0) return;
                _cbCity.Items.Clear();
                _cbCity.Items.AddRange(_cities.Select(d => d.ToString()).ToArray());
                _cbCity.SelectedIndex = 0;

                _streets = Controller.GetStreets(Convert.ToInt64(_regions[region].REGIONID), Convert.ToInt64(_districts[0].DISTRICTID), Convert.ToInt64(_cities[0].CITYID), Address.street);
                if (_streets == null || _streets.Count == 0) return;
                _cbStreet.Items.Clear();
                _cbStreet.Items.AddRange(_streets.Select(d => d.ToString()).ToArray());
                _cbStreet.SelectedIndex = 0;

                _houses = Controller.GetHouses(Convert.ToInt64(_streets[0].STREETID), Address.houseNumber);
                if (_houses == null || _houses.Count == 0) return;
                _cbHouse.Items.Clear();
                _cbHouse.Items.AddRange(_houses.Select(d => d.ToString()).ToArray());
                _cbHouse.SelectedIndex = 0;

                _tbApartment.Text = Address.apartmentNumber;
            }

        }
    }
}
