using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Generate the combo box named comboBoxColor with 4 members: Red, Blue, Dark, Undefined
            foreach (EnumColor currentColor in Enum.GetValues(typeof(EnumColor)))
            {
                this.comboBoxColor.Items.Add(currentColor);
            }

            // Generate the combo box named comboSuspension with 4 members: Front, Rear, Front_and_Rear, Undefined without the Underscore
            string[] enumSuspension = Enum.GetNames(typeof(EnumSuspension));
            foreach (var currentSuspension in enumSuspension)
            {
                this.comboBoxSuspension.Items.Add(currentSuspension.Replace("_", " "));
            }


            // Generate the combo box named comboBoxColor with 3 members: Modern, Classic, Undefined
            foreach (EnumStyle currentStyle in Enum.GetValues(typeof(EnumStyle)))
            {
                this.comboBoxMountainBikeStyle.Items.Add(currentStyle);
                this.comboBoxRoadBikeStyle.Items.Add(currentStyle);
            }

            // Generate the combo box named comboBoxTypeBike with 3 members: Road Bike, Mountain Bike, All_Bike without the Underscore
            string[] enumBikeType = Enum.GetNames(typeof(EnumBikeType));
            foreach (var currentTypeBike in enumBikeType)
            {
                this.comboBoxTypeBike.Items.Add(currentTypeBike.Replace("_", " "));
                this.comboBoxReset.Items.Add(currentTypeBike.Replace("_", " "));
            }

            // Generate the combo box named comboBoxTypeClear with 4 members: Road Bike, Mountain Bike, All_Bike, and None without the Underscore
            string[] enumTypeClear = Enum.GetNames(typeof(EnumTypeClear));
            foreach (var currentTypeClear in enumTypeClear)
            {
                this.comboBoxClear.Items.Add(currentTypeClear.Replace("_", " "));
            }
        }
        #region//this region is about declaring field, List,...
        private string checkBike;
        private int index = -1;
        private string chooseBike;
        public string optionDisplay;

        List<Bike> listOfBikes = new List<Bike>();
        List<RoadBike> listOfRoadBikes = new List<RoadBike>();
        List<MountainBike> listOfMountainBikes = new List<MountainBike>();
        #endregion

        #region//This Region is about Essential Methods

        private void Add()
        {
            SynchronizeListBike();
            Bike currentBike = null;
            long currentSerialNumber = 0;
            string currentMake = "Undefined", currentModel = "Undefined", currentInsurance = "Undefined";
            EnumColor currentColor = EnumColor.Undefined;
            double currentSpeed = 0.00;
            int currentDay, currentMonth, currentYear;

            Date currentDate = null;


            if (this.textBoxSerialNumber.Text != "")
            {
                bool pkSerialNumber = true;

                for (int i = 0; i < this.listOfBikes.Count; ++i)
                {
                    if (listOfBikes[i].SerialNumber == Convert.ToInt64(this.textBoxSerialNumber.Text))
                    {
                        pkSerialNumber = false;
                        break;
                    }
                }
                if (!pkSerialNumber)
                {
                    MessageBox.Show("Serial Number can not be duplicated", "Warning!!!");
                }
                else
                {
                    currentSerialNumber = Convert.ToInt64(this.textBoxSerialNumber.Text);
                    if (this.textBoxMake.Text != "")
                    {
                        currentMake = this.textBoxMake.Text;
                    }

                    if (this.textBoxModel.Text != "")
                    {
                        currentModel = this.textBoxModel.Text;
                    }

                    if (this.comboBoxColor.SelectedItem != null)
                    {
                        currentColor = (EnumColor)this.comboBoxColor.SelectedItem;
                        switch (optionDisplay)
                        {
                            case "Red":
                                {
                                    currentColor = (EnumColor)0;

                                    break;
                                }
                            case "Blue":
                                {
                                    currentColor = (EnumColor)1;
                                    break;
                                }
                            case "Dark":
                                {
                                    currentColor = (EnumColor)2;
                                    break;
                                }
                            case "Undefined":
                                {
                                    currentColor = (EnumColor)3;
                                    break;
                                }

                        }
                    }
                    if (this.textBoxInsurance.Text != "")
                    {
                        currentInsurance = this.textBoxInsurance.Text;
                    }
                    if (this.textBoxSpeed.Text != "")
                    {
                        currentSpeed = Convert.ToDouble(this.textBoxSpeed.Text);
                    }


                    currentDay = this.dateTimePicker.Value.Day;
                    currentMonth = this.dateTimePicker.Value.Month;
                    currentYear = this.dateTimePicker.Value.Year;
                    currentDate = new Date(currentDay, currentMonth, currentYear);

                    switch (checkBike)
                    {
                        case "RoadBike":
                            {
                                double currentSeatHeight = 0.00;
                                EnumStyle currentRoadBikeStyle = (EnumStyle)2;
                                if (this.textBoxSeatHeight.Text != "")
                                {
                                    currentSeatHeight = Convert.ToDouble(this.textBoxSeatHeight.Text);
                                }
                                if (this.comboBoxRoadBikeStyle.SelectedItem != null)
                                {
                                    currentRoadBikeStyle = (EnumStyle)this.comboBoxRoadBikeStyle.SelectedItem;
                                }

                                currentBike = new RoadBike(currentSerialNumber, currentModel, currentMake, currentColor, currentSpeed, currentDate, currentInsurance, currentSeatHeight, currentRoadBikeStyle);
                                var asking = MessageBox.Show($"Road Bike Information:\n\n{currentBike}\nDo you want to add the Bike in system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (asking == DialogResult.Yes)
                                {
                                    listOfBikes.Add(currentBike);
                                    this.listOfRoadBikes.Add((RoadBike)currentBike);
                                    FileManager.WriteIntoBinFileBikes(listOfBikes);
                                    FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                    MessageBox.Show("Adding a Road Bike into the Bike Factory System successfully", "Successfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("The Road Bike hasn't added into system");
                                }

                                break;
                            }
                        case "MountainBike":
                            {
                                double currentHeightFromGround = 0.00;
                                EnumStyle currentMountainBikeStyle = EnumStyle.Undefined;
                                EnumSuspension currentSuspension = EnumSuspension.Undefined;
                                if (this.textBoxHeightFromGround.Text != "")
                                {
                                    currentHeightFromGround = Convert.ToDouble(this.textBoxHeightFromGround.Text);
                                }
                                if (this.comboBoxMountainBikeStyle.SelectedItem != null)
                                {
                                    currentMountainBikeStyle = (EnumStyle)this.comboBoxMountainBikeStyle.SelectedItem;
                                }
                                if (this.comboBoxSuspension.SelectedItem != null)
                                {
                                    currentSuspension = (EnumSuspension)this.comboBoxSuspension.SelectedIndex;
                                }
                                currentBike = new MountainBike(currentSerialNumber, currentModel, currentMake, currentColor, currentSpeed, currentDate, currentHeightFromGround, currentSuspension, currentMountainBikeStyle, currentInsurance);
                                var asking = MessageBox.Show($"Mountain Bike Information:\n\n{currentBike}\nDo you want to add the Bike in system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (asking == DialogResult.Yes)
                                {
                                    listOfBikes.Add(currentBike);
                                    this.listOfMountainBikes.Add((MountainBike)currentBike);
                                    FileManager.WriteIntoBinFileBikes(listOfBikes);
                                    FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                    MessageBox.Show("Adding a Mountain Bike into the Bike Factory System successfully", "Successfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("The Mountain Bike hasn't added into system");
                                }
                                break;
                            }
                        default:
                            {
                                MessageBox.Show($"Serial number: {currentSerialNumber}\nMake by: {currentMake}\nModel: {currentModel}\nColor: {currentColor}\nSpeed: {currentSpeed} km/h\nDate: {currentDate}\nInsurance: {currentInsurance}\nWarning: This Bike won't be added into system due to the missing information of the type of Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                    }

                }
            }
            else
            {
                MessageBox.Show("You must insert the Serial Number to create a Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void Display()
        {
            SynchronizeListBike();


            if (this.comboBoxTypeBike.SelectedItem != null)
            {
                switch (this.comboBoxTypeBike.SelectedIndex)
                {
                    case (int)EnumBikeType.Mountain_Bike:
                        {

                            if (listOfMountainBikes.Count != 0)
                            {

                                DisplayListView("Mountain Bike");
                            }
                            else
                            {
                                MessageBox.Show("No data in List Mountain Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            break;
                        }
                    case (int)EnumBikeType.Road_Bike:
                        {

                            if (listOfRoadBikes.Count != 0)
                            {

                                DisplayListView("Road Bike");
                            }
                            else
                            {
                                MessageBox.Show("No data in List Road Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            break;
                        }
                    case (int)EnumBikeType.All_Bike:
                        {
                            listBoxBike.Items.Clear();
                            if (listOfBikes.Count != 0)
                            {
                                foreach (Bike bike in listOfBikes)
                                {
                                    this.listBoxBike.Items.Add(bike);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data in List Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }
                    case (int)EnumBikeType.Undefined:
                        {
                            MessageBox.Show("Please choose the List of Bikes you want to display", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Please choose the type of Bike to display", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Search()
        {
            SynchronizeListBike();
            long checkSerialNumber;
            bool isSerialNumberExist = false;
            if (this.textBoxSearch.Text.Length > 0)
            {
                checkSerialNumber = Convert.ToInt64(this.textBoxSearch.Text);
                foreach (Bike searchBike in listOfBikes)
                {
                    if (searchBike.SerialNumber == checkSerialNumber)
                    {
                        if (searchBike is MountainBike)
                        {
                            MessageBox.Show($"The Mountain Bike information:\n\n{searchBike}");
                        }
                        if (searchBike is RoadBike)
                        {
                            MessageBox.Show($"The Road Bike information:\n\n{searchBike}");
                        }
                        isSerialNumberExist = true;
                        break;
                    }
                }
                if (!isSerialNumberExist)
                {
                    MessageBox.Show($"There's not any Serial Number of the Bike matched with your information \nYour current input Serial Number: {checkSerialNumber}", "Not Found!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Please insert the Serial Number you want to look up", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void UpdateBike()
        {
            SynchronizeListBike();

            string updateMake, updateModel, updateInsurance;
            double updateSpeed;
            EnumColor updateColor;

            updateMake = this.textBoxMake.Text;
            updateModel = this.textBoxModel.Text;

            updateColor = (EnumColor)this.comboBoxColor.SelectedItem;
            switch (optionDisplay)
            {
                case "Red":
                    {
                        updateColor = (EnumColor)0;

                        break;
                    }
                case "Blue":
                    {
                        updateColor = (EnumColor)1;
                        break;
                    }
                case "Dark":
                    {
                        updateColor = (EnumColor)2;
                        break;
                    }
                case "Undefined":
                    {
                        updateColor = (EnumColor)3;
                        break;
                    }

            }

            updateInsurance = this.textBoxInsurance.Text;



            int updateDay = this.dateTimePicker.Value.Day;
            int updateMonth = this.dateTimePicker.Value.Month;
            int updateYear = this.dateTimePicker.Value.Year;
            Date updateDate = new Date(updateDay, updateMonth, updateYear);


            switch (this.chooseBike)
            {

                case "Bike":
                    {
                        index = listBoxBike.SelectedIndex;
                        if (listOfBikes[index] is RoadBike)
                        {

                            double updateSeatHeight;
                            EnumStyle updateRoadBikeStyle;

                            updateSpeed = Convert.ToDouble(this.textBoxSpeed.Text);
                            updateSeatHeight = Convert.ToDouble(this.textBoxSeatHeight.Text);
                            updateRoadBikeStyle = (EnumStyle)this.comboBoxRoadBikeStyle.SelectedItem;

                            Bike updateCurrentBike = new RoadBike(listOfBikes[index].SerialNumber, updateModel, updateMake, updateColor, updateSpeed, updateDate, updateInsurance, updateSeatHeight, updateRoadBikeStyle);


                            for (int i = 0; i < listOfRoadBikes.Count; ++i)
                            {
                                if (listOfBikes[index].SerialNumber == listOfRoadBikes[i].SerialNumber)
                                {
                                    var asking = MessageBox.Show($"Do you want to update this Road Bike of List Of Road Bike? \n\nThe information of this Road Bike is:\n\n{listOfRoadBikes[i]}", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (asking == DialogResult.Yes)
                                    {
                                        listOfRoadBikes[i] = (RoadBike)updateCurrentBike;
                                        listOfBikes[index] = updateCurrentBike;
                                        FileManager.WriteIntoBinFileBikes(listOfBikes);
                                        FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                        MessageBox.Show($"Updating the Road Bike item into the Bike Factory System successfully \n The information of Road Bike updated: \n {listOfRoadBikes[i]}", "Update Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Updating Road Bike procedure has been stopped", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    }

                                }

                                break;
                            }

                        }
                        else
                        {
                            EnumSuspension updateSuspension;
                            double updateHeightFromGround;
                            EnumStyle updateMountainBikeStyle;
                            updateSpeed = Convert.ToDouble(this.textBoxSpeed.Text);

                            updateSuspension = (EnumSuspension)this.comboBoxSuspension.SelectedIndex;
                            updateHeightFromGround = Convert.ToDouble(this.textBoxHeightFromGround.Text);
                            updateMountainBikeStyle = (EnumStyle)this.comboBoxMountainBikeStyle.SelectedItem;
                            Bike updateCurrentBike = new MountainBike(listOfBikes[index].SerialNumber, updateModel, updateMake, updateColor, updateSpeed, updateDate, updateHeightFromGround, updateSuspension, updateMountainBikeStyle, updateInsurance);


                            for (int i = 0; i < listOfMountainBikes.Count; ++i)
                            {

                                if (listOfBikes[index].SerialNumber == listOfMountainBikes[i].SerialNumber)
                                {
                                    var asking = MessageBox.Show($"Do you want to update this Mountain Bike of List Of Mountain Bike ? \n\nThe information of this Mountain Bike is:\n\n{listOfMountainBikes[i]}", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (asking == DialogResult.Yes)
                                    {
                                        listOfBikes[index] = updateCurrentBike;
                                        listOfMountainBikes[i] = (MountainBike)updateCurrentBike;
                                        FileManager.WriteIntoBinFileBikes(listOfBikes);
                                        FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                        MessageBox.Show($"Updating the Mountain Bike item into the Bike Factory System successfully \n The information of Mountain Bike updated: \n {listOfMountainBikes[i]}", "Update Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Updating Mountain Bike procedure has been stopped", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    }
                                    break;
                                }
                            }
                        }
                        break;
                    }
                case "Road Bike":
                    {
                        index = listViewRoadBike.FocusedItem.Index;
                        double updateSeatHeight;
                        EnumStyle updateRoadBikeStyle;
                        updateSpeed = Convert.ToDouble(this.textBoxSpeed.Text);

                        updateSeatHeight = Convert.ToDouble(this.textBoxSeatHeight.Text);
                        updateRoadBikeStyle = (EnumStyle)this.comboBoxRoadBikeStyle.SelectedItem;

                        Bike updateCurrentBike = new RoadBike(listOfRoadBikes[index].SerialNumber, updateModel, updateMake, updateColor, updateSpeed, updateDate, updateInsurance, updateSeatHeight, updateRoadBikeStyle);

                        for (int i = 0; i < listOfBikes.Count; ++i)
                        {
                            if (this.listOfRoadBikes[index].SerialNumber == this.listOfBikes[i].SerialNumber)
                            {
                                var asking = MessageBox.Show($"Do you want to update this Road Bike of List Of Road Bike? \n\nThe information of this Road Bike is:\n\n{listOfRoadBikes[index]}", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (asking == DialogResult.Yes)
                                {
                                    listOfRoadBikes[index] = (RoadBike)updateCurrentBike;
                                    listOfBikes[i] = updateCurrentBike;
                                    FileManager.WriteIntoBinFileBikes(listOfBikes);
                                    FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                    MessageBox.Show($"Updating the Road Bike item into the Bike Factory System successfully \n The information of Road Bike updated: \n {listOfRoadBikes[index]}", "Update Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                }
                                else
                                {
                                    MessageBox.Show("Your Updating Road Bike procedure has been stopped", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                }
                            }
                        }


                        break;
                    }
                case "Mountain Bike":
                    {
                        index = listViewMountainBike.FocusedItem.Index;
                        EnumSuspension updateSuspension;
                        double updateHeightFromGround;
                        EnumStyle updateMountainBikeStyle;
                        updateSpeed = Convert.ToDouble(this.textBoxSpeed.Text);

                        updateSuspension = (EnumSuspension)this.comboBoxSuspension.SelectedIndex;
                        updateHeightFromGround = Convert.ToDouble(this.textBoxHeightFromGround.Text);
                        updateMountainBikeStyle = (EnumStyle)this.comboBoxMountainBikeStyle.SelectedItem;
                        Bike updateCurrentBike = new MountainBike(listOfMountainBikes[index].SerialNumber, updateModel, updateMake, updateColor, updateSpeed, updateDate, updateHeightFromGround, updateSuspension, updateMountainBikeStyle, updateInsurance);

                        for (int i = 0; i < listOfBikes.Count; ++i)
                        {
                            if (this.listOfMountainBikes[index].SerialNumber == this.listOfBikes[i].SerialNumber)
                            {
                                var asking = MessageBox.Show($"Do you want to update this Mountain Bike of List Of Mountain Bike? \n\nThe information of this Mountain Bike is:\n\n{listOfMountainBikes[index]}", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (asking == DialogResult.Yes)
                                {
                                    listOfMountainBikes[index] = (MountainBike)updateCurrentBike;
                                    listOfBikes[i] = updateCurrentBike;
                                    FileManager.WriteIntoBinFileBikes(listOfBikes);
                                    FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                    MessageBox.Show($"Updating the Mountain Bike item into the Bike Factory System successfully \n The information of Mountain Bike updated: \n {listOfMountainBikes[index]}", "Update Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    MessageBox.Show("Your Updating Mountain Bike procedure has been stopped", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                        break;
                    }
            }
        }
        private void ClearBike()
        {

            bool checkClear = true;
            switch (this.comboBoxClear.SelectedIndex)
            {
                case 0:
                    {
                        this.listViewRoadBike.Items.Clear();
                        checkClear = true;
                        break;
                    }
                case 1:
                    {
                        this.listViewMountainBike.Items.Clear();
                        checkClear = true;
                        break;
                    }
                case 2:
                    {
                        this.listViewRoadBike.Items.Clear();
                        this.listViewMountainBike.Items.Clear();
                        this.listBoxBike.Items.Clear();
                        checkClear = true;
                        break;
                    }
                case 3:
                    {
                        checkClear = true;
                        break;
                    }
                default:
                    {
                        checkClear = false;
                        MessageBox.Show("Please choose List Box of Bike you want to clear or not", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
            }


            if (checkClear)
            {
                this.textBoxHeightFromGround.Text = "";
                this.textBoxInsurance.Text = "";
                this.textBoxSerialNumber.Text = "";
                this.textBoxMake.Text = "";
                this.textBoxModel.Text = "";
                this.textBoxSpeed.Text = "";
                this.textBoxSpeedUp.Text = "";
                this.textBoxSearch.Text = "";
                this.textBoxSeatHeight.Text = "";

                this.dateTimePicker.Value = DateTime.Now;
                this.comboBoxColor.SelectedIndex = (int)EnumColor.Undefined;
                this.comboBoxRoadBikeStyle.SelectedIndex = (int)EnumStyle.Undefined;
                this.comboBoxMountainBikeStyle.SelectedIndex = (int)EnumStyle.Undefined;
                this.comboBoxSuspension.SelectedIndex = (int)EnumSuspension.Undefined;
                this.comboBoxTypeBike.SelectedIndex = (int)EnumBikeType.All_Bike;
                this.textBoxSerialNumber.Focus();
                this.textBoxSerialNumber.Enabled = true;
            }
        }
        private void Remove()
        {
            switch (chooseBike)
            {
                case "Mountain Bike":
                    {
                        SynchronizeListBike();
                        index = listViewMountainBike.FocusedItem.Index;
                        var asking = MessageBox.Show($"Do you want to remove this Mountain Bike from the List? \n\nThis information of the Bike is: \n{listOfMountainBikes[index]}", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (asking == DialogResult.Yes)
                        {
                            MountainBike mountainBikeInfo = new MountainBike();
                            for (int i = 0; i < listOfBikes.Count; ++i)
                            {
                                if (listOfMountainBikes[index].SerialNumber == listOfBikes[i].SerialNumber)
                                {
                                    mountainBikeInfo = listOfMountainBikes[index];
                                    listOfBikes.RemoveAt(i);
                                    FileManager.WriteIntoBinFileBikes(listOfBikes);
                                    FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                    break;
                                }
                            }

                            listOfMountainBikes.RemoveAt(index);
                            MessageBox.Show($"Removing the Mountain Bike item in the Bike Factory System successfully \n The information of Mountain Bike removed: \n {mountainBikeInfo}", "Remove Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Your removing Mountain Bike procedure has been stopped", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        break;
                    }
                case "Road Bike":
                    {

                        index = listViewRoadBike.FocusedItem.Index;
                        var asking = MessageBox.Show($"Do you want to remove this Road Bike from the List? \n\nThis information of the Bike is: \n{listOfRoadBikes[index]}", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (asking == DialogResult.Yes)
                        {
                            RoadBike roadBikeInfo = new RoadBike();

                            for (int i = 0; i < listOfBikes.Count; ++i)
                            {
                                if (listOfRoadBikes[index].SerialNumber == listOfBikes[i].SerialNumber)
                                {
                                    roadBikeInfo = listOfRoadBikes[index];
                                    listOfBikes.RemoveAt(i);
                                    FileManager.WriteIntoBinFileBikes(listOfBikes);
                                    FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                    break;
                                }
                            }
                            listOfRoadBikes.RemoveAt(index);
                            MessageBox.Show($"Removing the Road Bike item in the Bike Factory System successfully \n The information of Road Bike removed: \n {roadBikeInfo}", "Remove Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Your removing Road Bike procedure has been stopped", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    }



                case "Bike":
                    {
                        index = this.listBoxBike.SelectedIndex;


                        if (listOfBikes[index] is RoadBike)
                        {
                            var asking = MessageBox.Show($"Do you want to remove this Road Bike from the List? \n\nThis information of the Bike is: \n{listOfBikes[index]}", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (asking == DialogResult.Yes)
                            {
                                RoadBike roadBikeInfo = new RoadBike();
                                for (int i = 0; i < listOfRoadBikes.Count; ++i)
                                {
                                    if (listOfBikes[index].SerialNumber == listOfRoadBikes[i].SerialNumber)
                                    {
                                        roadBikeInfo = listOfRoadBikes[i];
                                        listOfRoadBikes.RemoveAt(i);
                                        listOfBikes.RemoveAt(index);
                                        FileManager.WriteIntoBinFileBikes(listOfBikes);
                                        FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                        break;
                                    }
                                }

                                MessageBox.Show($"Removing the Road Bike item in the Bike Factory System successfully \n The information of Road Bike removed: \n {roadBikeInfo}", "Remove Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("Your removing Road Bike procedure has been stopped", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                        }
                        else
                        {
                            var asking = MessageBox.Show($"Do you want to remove this Mountain Bike item in the List? \n\nThis information of the Bike is: \n{listOfBikes[index]}", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (asking == DialogResult.Yes)
                            {
                                MountainBike mountainBikeInfo = new MountainBike();
                                for (int i = 0; i < listOfMountainBikes.Count; ++i)
                                {
                                    if (listOfBikes[index].SerialNumber == listOfMountainBikes[i].SerialNumber)
                                    {
                                        mountainBikeInfo = listOfMountainBikes[i];
                                        listOfMountainBikes.RemoveAt(i);
                                        listOfBikes.RemoveAt(index);
                                        FileManager.WriteIntoBinFileBikes(listOfBikes);
                                        FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                        break;
                                    }
                                }

                                MessageBox.Show($"Removing the Mountain Bike item in the Bike Factory System successfully \n The information of Road Bike removed: \n {mountainBikeInfo}", "Remove Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("Your removing Mountain Bike procedure has been stopped", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                        }

                        break;
                    }
            }
        }
        private void Reset()
        {
            SynchronizeListBike();
            switch (this.comboBoxReset.SelectedIndex)
            {
                case 1:
                    {
                        var asking = MessageBox.Show($"Do you want to Delete PERMANENTLY the List Of Mountain Bike in the Bike Factory System ? \n\nThe index of of List Mountain Bike in total is: {listOfMountainBikes.Count}", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (asking == DialogResult.Yes)
                        {
                            for (int i = listOfBikes.Count - 1; i >= 0; --i)
                            {
                                if (listOfBikes[i] is MountainBike)
                                {
                                    listOfBikes.RemoveAt(i);
                                    FileManager.WriteIntoBinFileBikes(listOfBikes);
                                    FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                }
                            }
                            this.listOfMountainBikes.Clear();
                            MessageBox.Show($"Delete the List of Mountain Bike PERMANENTLY in the Bike Factory System successfully", "Remove Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Your Deleting Mountain Bike procedure has been stopped", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        break;
                    }
                case 0:
                    {
                        var asking = MessageBox.Show($"Do you want to Delete PERMANENTLY the List Of Road Bike in the Bike Factory System ? \n\nThe index of of List Road Bike in total is: {listOfRoadBikes.Count}", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (asking == DialogResult.Yes)
                        {
                            for (int i = listOfBikes.Count - 1; i >= 0; --i)
                            {
                                if (listOfBikes[i] is RoadBike)
                                {
                                    listOfBikes.RemoveAt(i);
                                    FileManager.WriteIntoBinFileBikes(listOfBikes);
                                    FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                }
                            }
                            this.listOfRoadBikes.Clear();
                            MessageBox.Show($"Delete the List of Road Bike PERMANENTLY in the Bike Factory System successfully", "Remove Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            MessageBox.Show("Your Deleting Road Bike procedure has been stopped", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        break;
                    }
                case 2:
                    {
                        var asking = MessageBox.Show($"Do you want to Delete PERMANENTLY the List of Both Road Bike and Mountain Bike in the Bike Factory System ? \n\nThe index of of List Road Bike in total is: {listOfRoadBikes.Count}\nThe index of of List Mountain Bike in total is: {listOfMountainBikes.Count}", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (asking == DialogResult.Yes)
                        {
                            this.listOfBikes.Clear();
                            this.listOfRoadBikes.Clear();
                            this.listOfMountainBikes.Clear();
                            FileManager.WriteIntoBinFileBikes(listOfBikes);
                            FileManager.WriteIntoXmlFileBikes(listOfBikes);
                            MessageBox.Show($"Delete the List of Road Bike and Mountain Bike PERMANENTLY in the Bike Factory System successfully", "Remove Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        break;
                    }
            }
        }
        private void Exit()
        {
            var asking = MessageBox.Show("Do you want exit the application", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (asking == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for using our application", "THANK YOU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void SpeedUp()
        {
            SynchronizeListBike();
            switch (chooseBike)
            {
                case "Bike":
                    {
                        index = listBoxBike.SelectedIndex;
                        if (listOfBikes[index] is RoadBike)
                        {
                            double updateNewSpeed;

                            if (this.textBoxSpeedUp.Text.Length > 0)
                            {
                                updateNewSpeed = Convert.ToDouble(this.textBoxSpeedUp.Text);
                                for (int i = 0; i < listOfRoadBikes.Count; ++i)
                                {
                                    if (listOfBikes[index].SerialNumber == listOfRoadBikes[i].SerialNumber)
                                    {
                                        var asking = MessageBox.Show($"Do you want to update the new Max Speed of this Road Bike of List Of Road Bike? \n\nThe information of the current Speed is: {listOfRoadBikes[i].Speed} km/h", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (asking == DialogResult.Yes)
                                        {
                                            listOfRoadBikes[i].SpeedUp(updateNewSpeed);

                                            listOfBikes[index].Speed = listOfRoadBikes[i].Speed;
                                            FileManager.WriteIntoBinFileBikes(listOfBikes);
                                            FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                            if (listOfRoadBikes[i].Speed != 40.00)
                                            {
                                                MessageBox.Show($"Update the New Max Speed of Bike successfully \n The information of Max Speed of Road Bike updated: {listOfRoadBikes[i].Speed} km/h", "Update Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                            }
                                            else
                                            {
                                                MessageBox.Show($"Due to the limit Speed is 40 km/h, Update the New Max Speed of Bike successfully \n The information of Max Speed of Road Bike updated: {listOfRoadBikes[i].Speed} km/h", "Update Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show($"Your Update the New Max Speed of Bike Procedure has been stopped", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                        }

                                        break;
                                    }

                                }
                            }


                        }
                        else
                        {
                            double updateNewSpeed;
                            if (this.textBoxSpeedUp.Text.Length > 0)
                            {
                                updateNewSpeed = Convert.ToDouble(this.textBoxSpeedUp.Text);
                                for (int i = 0; i < listOfMountainBikes.Count; ++i)
                                {

                                    if (listOfBikes[index].SerialNumber == listOfMountainBikes[i].SerialNumber)
                                    {
                                        var asking = MessageBox.Show($"Do you want to update the new Max Speed of this Mountain Bike of List Of Mountain Bike? \n\nThe information of the current Speed is: {listOfMountainBikes[i].Speed} km/h", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (asking == DialogResult.Yes)
                                        {
                                            listOfMountainBikes[i].SpeedUp(updateNewSpeed);

                                            listOfBikes[index].Speed = listOfMountainBikes[i].Speed;
                                            FileManager.WriteIntoBinFileBikes(listOfBikes);
                                            FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                            if (listOfMountainBikes[i].Speed != 40.00)
                                            {
                                                MessageBox.Show($"Update the New Max Speed of Bike successfully \n The information of Max Speed of Mountain Bike updated: {listOfMountainBikes[i].Speed} km/h", "Update Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                            }
                                            else
                                            {
                                                MessageBox.Show($"Due to the limit Speed is 20 km/h, Update the New Max Speed of Bike successfully \n The information of Max Speed of Mountain Bike updated: {listOfMountainBikes[i].Speed} km/h", "Update Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show($"Your Update the New Max Speed of Bike Procedure has been stopped", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                        }
                                        break;
                                    }
                                }
                            }

                        }
                        break;
                    }
                case "Road Bike":
                    {
                        index = listViewRoadBike.FocusedItem.Index;
                        double updateNewSpeed;
                        if (this.textBoxSpeedUp.Text.Length > 0)
                        {
                            updateNewSpeed = Convert.ToDouble(this.textBoxSpeedUp.Text);
                            for (int i = 0; i < listOfBikes.Count; ++i)
                            {
                                if (listOfRoadBikes[index].SerialNumber == listOfBikes[i].SerialNumber)
                                {
                                    var asking = MessageBox.Show($"Do you want to update the new Max Speed of this Road Bike of List Of Road Bike? \n\nThe information of the current Speed is: {listOfRoadBikes[index].Speed} km/h", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (asking == DialogResult.Yes)
                                    {
                                        listOfRoadBikes[index].SpeedUp(updateNewSpeed);

                                        listOfBikes[i].Speed = listOfRoadBikes[index].Speed;
                                        FileManager.WriteIntoBinFileBikes(listOfBikes);
                                        FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                        if (listOfRoadBikes[index].Speed != 40.00)
                                        {
                                            MessageBox.Show($"Update the New Max Speed of Bike successfully \n The information of Max Speed of Road Bike updated: {listOfRoadBikes[index].Speed} km/h", "Update Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                        }
                                        else
                                        {
                                            MessageBox.Show($"Due to the limit Speed is 40 km/h, Update the New Max Speed of Bike successfully \n The information of Max Speed of Road Bike updated: {listOfRoadBikes[index].Speed} km/h", "Update Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show($"Your Update the New Max Speed of Bike Procedure has been stopped", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }

                                    break;
                                }

                            }
                        }



                        break;
                    }
                case "Mountain Bike":
                    {
                        index = listViewMountainBike.FocusedItem.Index;

                        double updateNewSpeed;
                        if (this.textBoxSpeedUp.Text.Length > 0)
                        {
                            updateNewSpeed = Convert.ToDouble(this.textBoxSpeedUp.Text);
                            for (int i = 0; i < listOfBikes.Count; ++i)
                            {

                                if (listOfBikes[i].SerialNumber == listOfMountainBikes[index].SerialNumber)
                                {
                                    var asking = MessageBox.Show($"Do you want to update the new Max Speed of this Mountain Bike of List Of Mountain Bike? \n\nThe information of the current Speed is: {listOfMountainBikes[index].Speed} km/h", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (asking == DialogResult.Yes)
                                    {
                                        listOfMountainBikes[index].SpeedUp(updateNewSpeed);

                                        listOfBikes[i].Speed = listOfMountainBikes[index].Speed;
                                        FileManager.WriteIntoBinFileBikes(listOfBikes);
                                        FileManager.WriteIntoXmlFileBikes(listOfBikes);
                                        if (listOfMountainBikes[index].Speed != 40.00)
                                        {
                                            MessageBox.Show($"Update the New Max Speed of Bike successfully \n The information of Max Speed of Mountain Bike updated: {listOfMountainBikes[index].Speed} km/h", "Update Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                        }
                                        else
                                        {
                                            MessageBox.Show($"Due to the limit Speed is 20 km/h, Update the New Max Speed of Bike successfully \n The information of Max Speed of Mountain Bike updated: {listOfMountainBikes[index].Speed} km/h", "Update Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Your Update the New Max Speed of Bike Procedure has been stopped", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }
                                    break;
                                }
                            }
                        }
                        break;
                    }
            }
        }
        private void SynchronizeListBike()
        {
            listOfBikes.Clear();
            listOfMountainBikes.Clear();
            listOfRoadBikes.Clear();

            listOfBikes = FileManager.ReadFromBinFileBikes();
            listOfBikes.Clear();
            listOfBikes = FileManager.ReadFromXmlFileBikes();
            if (listOfBikes.Count > 0)
            {
                foreach (Bike itemBike in listOfBikes)
                {
                    if (itemBike is MountainBike)
                    {
                        listOfMountainBikes.Add((MountainBike)itemBike);
                    }
                    else
                    {
                        listOfRoadBikes.Add((RoadBike)itemBike);
                    }
                }
            }
        }
        private void ViewColor()
        {
            DisplayImage linkDisplayImage = new DisplayImage();
            linkDisplayImage.linkData = new DisplayImage.DelegateData(PassedData);
            this.Hide();
            linkDisplayImage.ShowDialog();
            this.Show();
            switch (optionDisplay)
            {
                case "Red":
                    {
                        this.comboBoxColor.SelectedItem = EnumColor.Red;

                        break;
                    }
                case "Blue":
                    {
                        this.comboBoxColor.SelectedItem = EnumColor.Blue;
                        break;
                    }
                case "Dark":
                    {
                        this.comboBoxColor.SelectedItem = EnumColor.Dark;
                        break;
                    }
                case "Undefined":
                    {
                        this.comboBoxColor.SelectedItem = EnumColor.Undefined;
                        break;
                    }

            }
        }
        public void PassedData(string receivedData)
        {
            optionDisplay = receivedData;
        }
        public void DisplayListView(string displayBikes)
        {
            if (displayBikes == "Road Bike")
            {
                listViewRoadBike.Items.Clear();
                foreach (RoadBike element in listOfRoadBikes)
                {
                    ListViewItem anItem = new ListViewItem(Convert.ToString(element.SerialNumber));//key
                    anItem.SubItems.Add(element.Model);
                    anItem.SubItems.Add(element.Make);
                    anItem.SubItems.Add(Convert.ToString(element.Color));
                    anItem.SubItems.Add(Convert.ToString(element.Speed));
                    anItem.SubItems.Add(Convert.ToString(element.Date));
                    anItem.SubItems.Add(Convert.ToString(element.Insurance));
                    anItem.SubItems.Add(Convert.ToString(element.SeatHeight));
                    anItem.SubItems.Add(Convert.ToString(element.RoadBikeStyle));
                    listViewRoadBike.Items.Add(anItem);
                }
            }
            if (displayBikes == "Mountain Bike")
            {
                listViewMountainBike.Items.Clear();
                foreach (MountainBike element in listOfMountainBikes)
                {
                    ListViewItem anItem = new ListViewItem(Convert.ToString(element.SerialNumber));//key
                    anItem.SubItems.Add(element.Model);
                    anItem.SubItems.Add(element.Make);
                    anItem.SubItems.Add(Convert.ToString(element.Color));
                    anItem.SubItems.Add(Convert.ToString(element.Speed));
                    anItem.SubItems.Add(Convert.ToString(element.Date));
                    anItem.SubItems.Add(Convert.ToString(element.HeightFromGround));
                    anItem.SubItems.Add(Convert.ToString(element.Suspension));
                    anItem.SubItems.Add(Convert.ToString(element.MountainBikeStyle));
                    anItem.SubItems.Add(Convert.ToString(element.Insurance));
                    listViewMountainBike.Items.Add(anItem);
                }
            }

        }

        #endregion

        #region//This region is about ToolStrip
        private void roadBikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.checkBike = "RoadBike";
            this.textBoxSeatHeight.Visible = true;
            this.comboBoxRoadBikeStyle.Visible = true;
            this.labelSeatHeight.Visible = true;
            this.labelRoadBikeStyle.Visible = true;

            this.textBoxHeightFromGround.Visible = false;
            this.comboBoxSuspension.Visible = false;
            this.comboBoxMountainBikeStyle.Visible = false;
            this.labelSuspension.Visible = false;
            this.labelMountainBikeStyle.Visible = false;
            this.labelHeightFromGround.Visible = false;
            MessageBox.Show("Road Bike has been chosen", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mountainBikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.checkBike = "MountainBike";
            this.textBoxSeatHeight.Visible = false;
            this.comboBoxRoadBikeStyle.Visible = false;
            this.labelSeatHeight.Visible = false;
            this.labelRoadBikeStyle.Visible = false;


            this.textBoxHeightFromGround.Visible = true;
            this.comboBoxSuspension.Visible = true;
            this.comboBoxMountainBikeStyle.Visible = true;
            this.labelSuspension.Visible = true;
            this.labelMountainBikeStyle.Visible = true;
            this.labelHeightFromGround.Visible = true;
            MessageBox.Show("Mountain Bike has been chosen", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region//this region is about Key Press
        private void textBoxSerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled)
            {
                MessageBox.Show("Please input Digit from 0 to 9 for Serial Number", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled)
            {
                MessageBox.Show("Please input Digit from 0 to 9 to search the Bike by its Serial Number", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSeatHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
            if (e.Handled)
            {
                MessageBox.Show("Please input Number for Seat Height of Road Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxHeightFromGround_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
            if (e.Handled)
            {
                MessageBox.Show("Please input Number for Height from Ground of Mountain Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSpeedUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
            if (e.Handled)
            {
                MessageBox.Show("Please input the Number for new Speed of the Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxMake_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled)
            {
                MessageBox.Show("Please input Letter for Factory make the Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
            if (e.Handled)
            {
                MessageBox.Show("Please input Number for Speed of the Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInsurance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar);
            if (e.Handled)
            {
                MessageBox.Show("Please input Digit from 0 to 9 or Uppercase Letter for Speed of the Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region//this region is about the Button
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateBike();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearBike();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void buttonSpeedUp_Click(object sender, EventArgs e)
        {
            SpeedUp();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            ViewColor();
        }
        #endregion

        #region//this region is about List Box and List View Selected Index Change
        private void listBoxBike_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Due to the security of system, the Serial Number can not be modified in any situation", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.textBoxSpeedUp.Text = "";
            this.textBoxSerialNumber.Enabled = false;
            this.chooseBike = "Bike";
            index = this.listBoxBike.SelectedIndex;
            this.textBoxSerialNumber.Text = Convert.ToString(this.listOfBikes[index].SerialNumber);
            this.textBoxMake.Text = this.listOfBikes[index].Make;
            this.textBoxModel.Text = this.listOfBikes[index].Model;
            this.comboBoxColor.SelectedItem = this.listOfBikes[index].Color;
            this.textBoxInsurance.Text = this.listOfBikes[index].Insurance;
            this.textBoxSpeed.Text = Convert.ToString(this.listOfBikes[index].Speed);
            DateTime currentNewDate = new DateTime(this.listOfBikes[index].Date.Year, this.listOfBikes[index].Date.Month, this.listOfBikes[index].Date.Day);
            this.dateTimePicker.Value = currentNewDate;

            if (listOfBikes[index] is MountainBike)
            {

                this.textBoxSeatHeight.Visible = false;
                this.comboBoxRoadBikeStyle.Visible = false;
                this.labelSeatHeight.Visible = false;
                this.labelRoadBikeStyle.Visible = false;

                this.textBoxHeightFromGround.Visible = true;
                this.comboBoxSuspension.Visible = true;
                this.comboBoxMountainBikeStyle.Visible = true;
                this.labelSuspension.Visible = true;
                this.labelMountainBikeStyle.Visible = true;
                this.labelHeightFromGround.Visible = true;


                for (int j = 0; j < listOfMountainBikes.Count; ++j)
                {
                    if (listOfBikes[index].SerialNumber == listOfMountainBikes[j].SerialNumber)
                    {
                        index = j;
                    }
                }

                this.comboBoxSuspension.SelectedIndex = (int)this.listOfMountainBikes[index].Suspension;
                this.textBoxHeightFromGround.Text = Convert.ToString(this.listOfMountainBikes[index].HeightFromGround);
                this.comboBoxMountainBikeStyle.SelectedItem = this.listOfMountainBikes[index].MountainBikeStyle;
            }
            else
            {

                this.textBoxSeatHeight.Visible = true;
                this.comboBoxRoadBikeStyle.Visible = true;
                this.labelSeatHeight.Visible = true;
                this.labelRoadBikeStyle.Visible = true;


                this.textBoxHeightFromGround.Visible = false;
                this.comboBoxSuspension.Visible = false;
                this.comboBoxMountainBikeStyle.Visible = false;
                this.labelSuspension.Visible = false;
                this.labelMountainBikeStyle.Visible = false;
                this.labelHeightFromGround.Visible = false;
                this.textBoxSerialNumber.Text = Convert.ToString(this.listOfBikes[index].SerialNumber);

                for (int j = 0; j < listOfRoadBikes.Count; ++j)
                {
                    if (listOfBikes[index].SerialNumber == listOfRoadBikes[j].SerialNumber)
                    {
                        index = j;
                    }
                }


                this.textBoxSeatHeight.Text = Convert.ToString(this.listOfRoadBikes[index].SeatHeight);
                this.comboBoxRoadBikeStyle.SelectedItem = this.listOfRoadBikes[index].RoadBikeStyle;

            }
        }

        private void listViewRoadBike_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Due to the security of system, the Serial Number can not be modified in any situation", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.textBoxSerialNumber.Enabled = false;

            this.textBoxSpeedUp.Text = "";

            this.textBoxSeatHeight.Visible = true;
            this.comboBoxRoadBikeStyle.Visible = true;
            this.labelSeatHeight.Visible = true;
            this.labelRoadBikeStyle.Visible = true;



            this.textBoxHeightFromGround.Visible = false;
            this.comboBoxSuspension.Visible = false;
            this.comboBoxMountainBikeStyle.Visible = false;
            this.labelSuspension.Visible = false;
            this.labelMountainBikeStyle.Visible = false;
            this.labelHeightFromGround.Visible = false;


            this.chooseBike = "Road Bike";
            index = listViewRoadBike.FocusedItem.Index;
            this.textBoxSerialNumber.Text = Convert.ToString(this.listOfRoadBikes[index].SerialNumber);
            this.textBoxMake.Text = this.listOfRoadBikes[index].Make;
            this.textBoxModel.Text = this.listOfRoadBikes[index].Model;
            this.comboBoxColor.SelectedItem = this.listOfRoadBikes[index].Color;
            this.textBoxInsurance.Text = this.listOfRoadBikes[index].Insurance;
            this.textBoxSpeed.Text = Convert.ToString(this.listOfRoadBikes[index].Speed);
            DateTime currentDate = new DateTime(this.listOfRoadBikes[index].Date.Year, this.listOfRoadBikes[index].Date.Month, this.listOfRoadBikes[index].Date.Day);
            this.textBoxSeatHeight.Text = Convert.ToString(this.listOfRoadBikes[index].SeatHeight);
            this.comboBoxRoadBikeStyle.SelectedItem = this.listOfRoadBikes[index].RoadBikeStyle;
        }

        private void listViewMountainBike_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Due to the security of system, the Serial Number can not be modified in any situation", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.textBoxSerialNumber.Enabled = false;
            this.chooseBike = "Mountain Bike";

            this.textBoxSpeedUp.Text = "";

            this.textBoxSeatHeight.Visible = false;
            this.comboBoxRoadBikeStyle.Visible = false;
            this.labelSeatHeight.Visible = false;
            this.labelRoadBikeStyle.Visible = false;

            this.textBoxHeightFromGround.Visible = true;
            this.comboBoxSuspension.Visible = true;
            this.comboBoxMountainBikeStyle.Visible = true;
            this.labelSuspension.Visible = true;
            this.labelMountainBikeStyle.Visible = true;
            this.labelHeightFromGround.Visible = true;

            index = listViewMountainBike.FocusedItem.Index;
            this.textBoxSerialNumber.Text = Convert.ToString(this.listOfMountainBikes[index].SerialNumber);
            this.textBoxMake.Text = this.listOfMountainBikes[index].Make;
            this.textBoxModel.Text = this.listOfMountainBikes[index].Model;
            this.comboBoxColor.SelectedItem = this.listOfMountainBikes[index].Color;
            this.textBoxInsurance.Text = this.listOfMountainBikes[index].Insurance;
            this.textBoxSpeed.Text = Convert.ToString(this.listOfMountainBikes[index].Speed);
            DateTime currentDate = new DateTime(this.listOfMountainBikes[index].Date.Year, this.listOfMountainBikes[index].Date.Month, this.listOfMountainBikes[index].Date.Day);
            this.comboBoxSuspension.SelectedItem = this.listOfMountainBikes[index].Suspension;
            this.textBoxHeightFromGround.Text = Convert.ToString(this.listOfMountainBikes[index].HeightFromGround);
            this.comboBoxMountainBikeStyle.SelectedItem = this.listOfMountainBikes[index].MountainBikeStyle;
        }
        #endregion
    }
}
