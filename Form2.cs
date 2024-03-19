using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
namespace WeddingBook
{
    public partial class Form2 : Form
    {
        public Package package = new Package();
        public AdditionalFEE additionalfee = new AdditionalFEE();
        public LocationVenue Locationvenue = new LocationVenue();
        public Addons adons = new Addons();


        public Form2()
        {
            InitializeComponent();

        }
        private void IfLocation()
        {
            string venueLocation;
            if (wherecombobox.SelectedIndex == 0)
            {
                sariayavenuename.Visible = true;
                lucenavenuename.Visible = false;
                candelariavenuename.Visible = false;
                if (sariayavenuename.SelectedIndex == 0)
                {
                    venueLocation = "St. Francis of Assisi Parish Church";
                }
                else
                {
                    venueLocation = "Immaculate Concepcion Parish Church";
                }
            }
            else if (wherecombobox.SelectedIndex == 1)
            {
                lucenavenuename.Visible = true;
                sariayavenuename.Visible = false;
                candelariavenuename.Visible = false;
                if (lucenavenuename.SelectedIndex == 0)
                {
                    venueLocation = "St.Ferdinand Cathederal Parish";
                }
                else
                {
                    venueLocation = "Our Lady of Lourdes Parish Church";
                }
            }
            else
            {
                candelariavenuename.Visible = true;
                sariayavenuename.Visible = false;
                lucenavenuename.Visible = false;
                if (candelariavenuename.SelectedIndex == 0)
                {
                    venueLocation = "San Pedro Baustista Parish Church";
                }
                else
                {
                    venueLocation = "St. Catherine of Siena Parish Church";
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CustomDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BrideNameBox.Text) && !string.IsNullOrEmpty(GroomNameBox.Text) && !string.IsNullOrEmpty(storybox.Text) && !string.IsNullOrEmpty(contactNumberbox.Text) && !string.IsNullOrEmpty(emailAddressbox.Text))
            {
                int sum = additionalfee.Totalprice + package.pricepackage;
                pictureBox1.Visible = false;
                listBox1.Items.Add("Wedding Date: " + weddingdatetimepicker.Value);
                listBox1.Items.Add("Bride's Name: " + BrideNameBox.Text);
                listBox1.Items.Add("Groom's Name: " + GroomNameBox.Text);
                listBox1.Items.Add("Email: " + emailAddressbox.Text);
                listBox1.Items.Add("Contact Number: " + ContactInformation.Text);
                listBox1.Items.Add("Brief story: " + storybox.Text);
                listBox1.Items.Add("Contact Number: " + ContactInformation.Text);
                listBox1.Items.Add("Package: " + package.packagename);d
                listBox1.Items.Add("Total price: " + sum.ToString("C", CultureInfo.GetCultureInfo("en-PH")));
                MessageBox.Show("Registered Success!", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string message = "Please fill up the remaining blank";
                if (string.IsNullOrEmpty(BrideNameBox.Text))
                {
                    message += "\n- Bride's Name";
                }

                if (string.IsNullOrEmpty(GroomNameBox.Text))
                {
                    message += "\n- Groom's Name";
                }
                if (string.IsNullOrEmpty(emailAddressbox.Text))
                {
                    message += "\n- Email Address";
                }
                if (string.IsNullOrEmpty(contactNumberbox.Text))
                {
                    message += "\n- Contact Number";
                }
                if (string.IsNullOrEmpty(storybox.Text))
                {
                    message += "\n- Brief Story";
                }
                MessageBox.Show(message, "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void emailAddressbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void BrideNameBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void GroomNameBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void drone_CheckedChanged(object sender, EventArgs e)
        {
            if (drone.Checked)
            {

                additionalfee.Totalprice += 10000;
                totallistbox.Items.Add("Drone aerial photography = php 10,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 10000;
                totallistbox.Items.Remove("Drone aerial photography = php 10,000");
                UpdateFee();
            }
        }

        private void weddingofficiant_CheckedChanged(object sender, EventArgs e)
        {

        }

        public class AdditionalFEE
        {
            public int Totalprice { get; set; }
        }
        public class LocationVenue
        {
            public string locationvenue { get; set; }
        }


        private void additionalServices_Load(object sender, EventArgs e)
        {
        }

        private void UpdateFee()
        {
            for (int i = 0; i < totallistbox.Items.Count; i++)
            {
                if (totallistbox.Items[i].ToString().StartsWith("Total:"))
                {
                    totallistbox.Items.RemoveAt(i);
                    break;
                }
            }

            int fee = additionalfee.Totalprice;
            totallistbox.Items.Add("Total: " + fee.ToString("C", CultureInfo.GetCultureInfo("en-PH")));
        }

        private void videography_Enter(object sender, EventArgs e)
        {

        }

        private void candelariavenuename_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sariayavenuename_SelectedIndexChanged(object sender, EventArgs e)
        {
            IfLocation();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        } 
        public class Addons
        {
            public string addons { get; set; }
        }
        public class Package
        {
            public string packagename { get; set; }
            public int pricepackage { get; set; }
        }

        private void photosession_CheckedChanged_1(object sender, EventArgs e)
        {
            if (photosession.Checked)
            {
                adons.addons += photosession.Text + "\n";
                additionalfee.Totalprice += 3000;
                totallistbox.Items.Add(photosession.Text + " = " + "php 3,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 3000;
                totallistbox.Items.Remove(photosession.Text + " = " + "php 3,000");
                UpdateFee();
            }
        }

        private void weddingofficiant_CheckedChanged_1(object sender, EventArgs e)
        {
            if (weddingofficiant.Checked)
            {
                adons.addons += weddingofficiant.Text + "\n"; 
                additionalfee.Totalprice += 12000;
                totallistbox.Items.Add(weddingofficiant.Text + " = " + "php 12,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 12000;
                totallistbox.Items.Remove(weddingofficiant.Text + " = " + "php 12,000");
                UpdateFee();
            }
        }

        private void Customphotoalbums_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Customphotoalbums.Checked)
            {
                adons.addons += Customphotoalbums.Text + "\n";
                additionalfee.Totalprice += 2000;
                totallistbox.Items.Add(Customphotoalbums.Text + " = " + "php 2,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 2000;
                totallistbox.Items.Remove(Customphotoalbums.Text + " = " + "php 2,000");
                UpdateFee();
            }
        }

        private void SameDayEdit_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SameDayEdit.Checked)
            {
                adons.addons += SameDayEdit.Text + "\n";
                additionalfee.Totalprice += 5000;
                totallistbox.Items.Add(SameDayEdit.Text + " = " + "php 5,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 5000;
                totallistbox.Items.Remove(SameDayEdit.Text + " = " + "php 5,000");
                UpdateFee();
            }
        }

        private void liveband_CheckedChanged(object sender, EventArgs e)
        {
            if (liveband.Checked)
            {
                adons.addons += liveband.Text + "\n";
                additionalfee.Totalprice += 10000;
                totallistbox.Items.Add(liveband.Text + " = " + "php 10,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 10000;
                totallistbox.Items.Remove(liveband.Text + " = " + "php 10,000");
                UpdateFee();
            }
        }

        private void Fullfeatureweddingfilm_CheckedChanged(object sender, EventArgs e)
        {
            if (Fullfeatureweddingfilm.Checked)
            {
                adons.addons += Fullfeatureweddingfilm.Text + "\n";
                additionalfee.Totalprice += 8000;
                totallistbox.Items.Add(Fullfeatureweddingfilm.Text + " = " + "php 8,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 8000;
                totallistbox.Items.Remove(Fullfeatureweddingfilm.Text + " = " + "php 8,000");
                UpdateFee();
            }
        }

        private void interview_CheckedChanged(object sender, EventArgs e)
        {
            if (interview.Checked)
            {
                adons.addons += interview.Text + "\n";
                additionalfee.Totalprice += 5000;
                totallistbox.Items.Add(interview.Text + " = " + "php 5,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 5000;
                totallistbox.Items.Remove(interview.Text + " = " + "php 5,000");
                UpdateFee();
            }
        }

        private void djservices_CheckedChanged(object sender, EventArgs e)
        {
            if (djservices.Checked)
            {
                adons.addons += djservices.Text + "\n";
                additionalfee.Totalprice += 5000;
                totallistbox.Items.Add(djservices.Text + " = " + "php 5,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 5000;
                totallistbox.Items.Remove(djservices.Text + " = " + "php 5,000");
                UpdateFee();
            }
        }

        private void famousartist_CheckedChanged(object sender, EventArgs e)
        {
            if (famousartist.Checked)
            {
                adons.addons += famousartist.Text + "\n";
                additionalfee.Totalprice += 20000;
                totallistbox.Items.Add(famousartist.Text + " = " + "php 20,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 20000;
                totallistbox.Items.Remove(famousartist.Text + " = " + "php 20,000");
                UpdateFee();
            }
        }

        private void gownandtuxedo_CheckedChanged(object sender, EventArgs e)
        {
            if (gownandtuxedo.Checked)
            {
                adons.addons += gownandtuxedo.Text + "\n";
                additionalfee.Totalprice += 15000;
                totallistbox.Items.Add(gownandtuxedo.Text + " = " + "php 15,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 15000;
                totallistbox.Items.Remove(gownandtuxedo.Text + " = " + "php 15,000");
                UpdateFee();
            }
        }

        private void accesoriespackage_CheckedChanged(object sender, EventArgs e)
        {
            if (accesoriespackage.Checked)
            {  
                adons.addons += accesoriespackage.Text + "\n";
                additionalfee.Totalprice += 8000;
                totallistbox.Items.Add(accesoriespackage.Text + " = " + "php 8,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 8000;
                totallistbox.Items.Remove(accesoriespackage.Text + " = " + "php 8,000");
                UpdateFee();
            }
        }

        private void childcareservices_CheckedChanged_1(object sender, EventArgs e)
        {
            if (childcareservices.Checked)
            {
                adons.addons += childcareservices.Text + "\n";
                additionalfee.Totalprice += 5000;
                totallistbox.Items.Add(childcareservices.Text + " = " + "php 5,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 5000;
                totallistbox.Items.Remove(childcareservices.Text + " = " + "php 5,000");
                UpdateFee();
            }
        }

        private void weddinginsurance_CheckedChanged(object sender, EventArgs e)
        {
            if (weddinginsurance.Checked)
            {
                adons.addons += weddinginsurance.Text + "\n";
                additionalfee.Totalprice += 15000;
                totallistbox.Items.Add(weddinginsurance.Text + " = " + "php 15,000");
                UpdateFee();
            }
            else
            {
                additionalfee.Totalprice -= 15000;
                totallistbox.Items.Remove(weddinginsurance.Text + " = " + "php 15,000");
                UpdateFee();
            }
        }

        private void classicpackage_CheckedChanged_1(object sender, EventArgs e)
        {
            if (classicpackage.Checked)
            {
                package.packagename = "Classic Wedding Package";
                package.pricepackage = 155000;
                classicprice.Visible = true;
            }
            if (!classicpackage.Checked)
            {
                classicprice.Visible = false;
            }
        }

        private void grandpackage_CheckedChanged_1(object sender, EventArgs e)
        {
            if (grandpackage.Checked)
            {
                package.packagename = "Grand Wedding Package";
                package.pricepackage = 250000;
                grandprice.Visible = true;
            }
            if (!grandpackage.Checked)
            {
                grandprice.Visible = false;
            }
        }

        private void deluxpackage_CheckedChanged(object sender, EventArgs e)
        {
            if (deluxpackage.Checked)
            {

                package.packagename = "Deluxe Wedding Package";
                package.pricepackage = 380000;
                deluxprice.Visible = true;
            }
            if (!deluxpackage.Checked)
            {
                deluxprice.Visible = false;
            }
        }

        private void majesticpackage_CheckedChanged(object sender, EventArgs e)
        {
            if (majesticpackage.Checked)
            {
                package.packagename = "Majestic Wedding Package";
                package.pricepackage = 440000;
                majesticprice.Visible = true;
            }
            if (!majesticpackage.Checked)
            {
                majesticprice.Visible = false;
            }
        }


        private void royalpackage_CheckedChanged(object sender, EventArgs e)
        {
            if (royalpackage.Checked)
            {
                package.packagename = "Royal Wedding Package";
                package.pricepackage = 550000;
                royalprice.Visible = true;
            }
            if (!royalpackage.Checked)
            {
                royalprice.Visible = false;
            }
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Food and Decoration\r\n------------------------\r\n- Welcome Treats: Appetizers as your guests arrive at the venue\r\n- UPGRADED Full-Course Buffet Menu with Free Flowing Drinks \r\n(Menu available upon request)\r\n- Personalized Labels for each dish\r\n- Use of complete sets of Dinnerware, Flatware and Glassware\r\n- Complete Table Setting with Table Numbers\r\n- Dressed Banquet Tables with Cloth Table Napkins\r\n- Special VIP Treatment Food Service for the Presidential Table \r\n- Professionally Trained Banquet Staff in Uniform\r\n- Pair of Doves for Dove Release Tradition\r\n- Bottle of Wine for Wedding Toast\r\n- Red Carpet\r\n- Elegant Ghost Chairs for all guests\r\n- Candice Chairs for VIP (22pax)\r\n------------------------\r\nPhoto and Video Coverage with PreNuptial Pictorial,\r\nGuestbook and Wedding Album\r\n(Preparation to Ceremony to Reception)\r\n------------------------\r\n- Pre-Nuptial Pictorial with PROPS and STYLING\r\n- 4 Professional Videographers w/ HD Video DSLR Video Camera\r\n1 Creative Videographer / Editor\r\n1 Main Videographer\r\n​1 Second Angle Videographer\r\n1 Aerial Videographer / Third Angle Candids Videographer\r\nComplete with Creative Equipments for Cinematic Shots \r\n(Stabilizers, Slider, Tripod, Etc)\r\n- 4 Professional Photographers w/ Digital SLR Camera\r\n1 Creative Photographer\r\n1 Main Photographer\r\n1 Second Angle Photographer\r\n1 Candids / Details Photographer / Onsite Photo Editor\r\n- Edited Video (20-30 mins Highlights) \r\n- 8x10 40 pages Magnetic Guestbook with Prenuptial Pictures\r\n- 10x10 40 pages Wedding Album with Leather Box\r\n- Two (2) 8x10 20 pages Parents' Magnetic Album\r\n- Couple's Growing Up AVP or Then and Now Slideshow\r\n- Pre-Wedding Film with Aerial Shots (2-3 mins Prenup Video)\r\n-  SAME DAY EDIT PHOTO - Onsite Wedding Photo Highlights\r\n(3-5 mins Wedding Highlights to be played during reception)\r\n-  SAME DAY EDIT VIDEO - Onsite Wedding Video Highlights\r\n(3-5 mins  Wedding Highlights to be played during reception)\r\n- AERIAL VIDEOGRAPHY during Prenup and Wedding Day\r\n- Awesome Events 16 Gig USB for Photo / Video Highlights\r\n- 1 Terabyte External Hard Drive for all Photo / Video Files\r\n- A beautiful Memory Book to showcase your Wedding films ​\r\n​------------------------\r\nWedding Cake, Invitation and Give-Aways\r\n------------------------\r\n- 100 pieces Wedding Invitations\r\n- 6 Layer Fondant Themed - Wedding  Cake with Topper\r\n- 10 pcs Fondant Mini-Cakes for Principal Sponsor Give-aways", "Royal Wedding Package Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Food and Decoration\r\n------------------------\r\n- Welcome Treats: Appetizers as your guests arrive at the venue\r\n- UPGRADED Full-Course Buffet Menu with Free Flowing Drinks \r\n(Menu available upon request)\r\n- Personalized Labels for each dish\r\n- Use of complete sets of Dinnerware, Flatware and Glassware\r\n- Complete Table Setting with Table Numbers\r\n- Dressed Banquet Tables with Cloth Table Napkins\r\n- Special VIP Treatment Food Service for the Presidential Table \r\n- Professionally Trained Banquet Staff in Uniform\r\n- Pair of Doves for Dove Release Tradition\r\n- Bottle of Wine for Wedding Toast\r\n- Red Carpet\r\n- Elegant Ghost Chairs for all guests\r\n- Candice Chairs for VIP (22pax)\r\n------------------------\r\nPhoto and Video Coverage with PreNuptial Pictorial,\r\nGuestbook and Wedding Album\r\n(Preparation to Ceremony to Reception)\r\n------------------------\r\n- Pre-Nuptial Pictorial with PROPS and STYLING\r\n- 4 Professional Videographers w/ HD Video DSLR Video Camera\r\n1 Creative Videographer / Editor\r\n1 Main Videographer\r\n​1 Second Angle Videographer\r\n1 Aerial Videographer / Third Angle Candids Videographer\r\nComplete with Creative Equipments for Cinematic Shots \r\n(Stabilizers, Slider, Tripod, Etc)\r\n- 4 Professional Photographers w/ Digital SLR Camera\r\n1 Creative Photographer\r\n1 Main Photographer\r\n1 Second Angle Photographer\r\n1 Candids / Details Photographer / Onsite Photo Editor\r\n- Edited Video (20-30 mins Highlights) \r\n- 8x10 40 pages Magnetic Guestbook with Prenuptial Pictures\r\n- 10x10 40 pages Wedding Album with Leather Box\r\n- Two (2) 8x10 20 pages Parents' Magnetic Album\r\n- Couple's Growing Up AVP or Then and Now Slideshow\r\n- Pre-Wedding Film with Aerial Shots (2-3 mins Prenup Video)\r\n-  SAME DAY EDIT PHOTO - Onsite Wedding Photo Highlights\r\n(3-5 mins Wedding Highlights to be played during reception)\r\n-  SAME DAY EDIT VIDEO - Onsite Wedding Video Highlights\r\n(3-5 mins  Wedding Highlights to be played during reception)\r\n- AERIAL VIDEOGRAPHY during Prenup and Wedding Day\r\n- Awesome Events 16 Gig USB for Photo / Video Highlights\r\n- 1 Terabyte External Hard Drive for all Photo / Video Files\r\n- A beautiful Memory Book to showcase your Wedding films ​\r\n​------------------------\r\nWedding Cake, Invitation and Give-Aways\r\n------------------------\r\n- 100 pieces Wedding Invitations\r\n- 6 Layer Fondant Themed - Wedding  Cake with Topper\r\n- 10 pcs Fondant Mini-Cakes for Principal Sponsor Give-aways", "Royal Wedding Package Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Food and Decoration\r\n------------------------\r\n- Welcome Treats: Appetizers as your guests arrive at the venue\r\n- UPGRADED Full-Course Buffet Menu with Free Flowing Drinks \r\n(Menu available upon request)\r\n- Personalized Labels for each dish\r\n- Use of complete sets of Dinnerware, Flatware and Glassware\r\n- Complete Table Setting with Table Numbers\r\n- Dressed Banquet Tables with Cloth Table Napkins\r\n- Special VIP Treatment Food Service for the Presidential Table \r\n- Professionally Trained Banquet Staff in Uniform\r\n- Pair of Doves for Dove Release Tradition\r\n- Bottle of Wine for  Wedding  Toast\r\n- Red Carpet\r\n- Elegant Ghost Crystal Chairs for all guests\r\n------------------------\r\n\nString Ensemble Trio\r\n------------------------﻿﻿\r\n- 1 Singer\r\n- 1 Violinist \r\n- 1 Pianist\r\n- For Ceremony and Reception\r\n------------------------\r\nMobile Bar\r\n------------------------ \r\n- Lighted Mobile Bar\r\n- 10 Choices of Cocktails / Mocktails\r\n- 50 pcs Beer in Can or Flavored Beer \r\n------------------------ \r\nCandy Buffet Station with Pastry Corner\r\n------------------------\r\n- Assorted candies, sweets and pastries for guests to enjoy\n\nWedding Cake, Invitation and Give-Aways\r\n------------------------\r\n- 80 pieces Wedding Invitations\r\n- 4 Layer Fondant Themed - Wedding Cake with Topper\r\n- 10 pcs Fondant Mini-Cakes for Principal Sponsor Give-aways\r\n- 100 pcs Fondant Cupcakes for Guest Give-aways\r\n- 4 Hours Photobooth with Props and STOP TIME\n\nBridal Bouquet and Entourage Flowers\r\n------------------------ \r\n- Elegant Bouquet for Bride \r\nUpgraded to Imported flowers (Tulips or Ecuadorian Roses)\r\n- Corsages, Boutonnieres, Wristlets for Entourage\r\n- Baskets for Flower Girls- Lose Petal\n\n Hair and Makeup (Airbrush) \r\n------------------------\r\n- Prenup - Traditional Hair and Makeup (Trial)\r\n- Wedding Day - Airbrush Hair and Makeup for Bride only\r\n- Bride and Groom (If same preparation place)\r\n- 3 additional heads (mother,maid of honor,etc)\r\n- Unlimited Retouch before Reception \r\n﻿﻿------------------------\r\nString Ensemble Trio\r\n------------------------﻿﻿\r\n- 1 Singer\r\n- 1 Violinist \r\n- 1 Pianist\r\n- For Ceremony and Reception", "Deluxe Wedding Package", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Food and Decoration\r\n------------------------\r\n- Welcome Treats: Appetizers as your guests arrive at the venue\r\n- UPGRADED Full-Course Buffet Menu with Free Flowing Drinks \r\n(Menu available upon request)\r\n- Personalized Labels for each dish\r\n- Use of complete sets of Dinnerware, Flatware and Glassware\r\n- Complete Table Setting with Table Numbers\r\n- Dressed Banquet Tables with Cloth Table Napkins\r\n- Special VIP Treatment Food Service for the Presidential Table \r\n- Professionally Trained Banquet Staff in Uniform\r\n- Pair of Doves for Dove Release Tradition\r\n- Bottle of Wine for Wedding  Toast\r\n- Red Carpet\r\n- Elegant Ghost Chairs for all guests\n\nPhoto and Video Coverage with PreNuptial Pictorial,\r\nGuestbook and Wedding Album\r\n(Preparation to Ceremony to Reception)\r\n------------------------\r\n- Pre-Nuptial Pictorial with PROPS and STYLING\r\n- 4 Professional Videographers w/ HD Video DSLR Video Camera\r\n1 Creative Videographer / Editor\r\n1 Main Videographer\r\n​1 Second Angle Videographer\r\n1 Aerial Videographer / Third Angle Candids Videographer\r\nComplete with Creative Equipments for Cinematic Shots \r\n(Stabilizers, Slider, Tripod, Etc)\r\n- 4 Professional Photographers w/ Digital SLR Camera\r\n1 Creative Photographer\r\n1 Main Photographer\r\n1 Second Angle Photographer\r\n1 Candids / Details Photographer / Onsite Photo Editor\r\n- Edited Video (20-30 mins Highlights) \r\n- 8x10 40 pages Magnetic Guestbook with Prenuptial Pictures\r\n- 8x10 40 pages Wedding Album with Leather Box\r\n- Two (2) 8x10 Parents' Album\r\n- Couple's Growing Up AVP or Then and Now Slideshow\r\n- Pre-Wedding Film with Aerial Shots (2-3 mins Prenup Video)\r\n-  SAME DAY EDIT PHOTO - Onsite Wedding Photo Highlights\r\n(3-5 mins Wedding Highlights to be played during reception)\r\n-  SAME DAY EDIT VIDEO - Onsite Wedding Video Highlights\r\n(3-5 mins  Wedding Highlights to be played during reception)\r\n- AERIAL VIDEOGRAPHY during Prenup and Wedding Day\r\n- Awesome Events 16 Gig USB for Photo / Video Highlights\r\n- 500 gig External Hard Drive for Photo / Video Files\r\n- A beautiful Memory Book to showcase your Wedding films \n\nOn the Day Coordination with Emcee\r\n------------------------\r\n- 1 Program Emcee\r\n- 4 Coordinators from Preparation to Ceremony to Reception\r\n- 1 Bride Manager to assist the bride throughout the day\r\n- 1 Groom Manager to assist the groom throughout the day", "Majesstic Wedding Package Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Food and Decoration\r\n------------------------\r\n- Welcome Treats: Appetizers as your guests arrive at the venue\r\n- UPGRADED Full-Course Buffet Menu with Free Flowing Drinks \r\n(Menu available upon request)\r\n- Personalized Labels for each dish\r\n- Use of complete sets of Dinnerware, Flatware and Glassware\r\n- Complete Table Setting with Table Numbers\r\n- Dressed Banquet Tables with Cloth Table Napkins\r\n- Special VIP Treatment Food Service for the Presidential Table \r\n- Professionally Trained Banquet Staff in Uniform\r\n- Pair of Doves for Dove Release Tradition\r\n- Bottle of Wine for Wedding  Toast\r\n- Red Carpet\r\n- Elegant Ghost Chairs for all guests\n\nPhoto and Video Coverage with PreNuptial Pictorial,\r\nGuestbook and Wedding Album\r\n(Preparation to Ceremony to Reception)\r\n------------------------\r\n- Pre-Nuptial Pictorial with PROPS and STYLING\r\n- 4 Professional Videographers w/ HD Video DSLR Video Camera\r\n1 Creative Videographer / Editor\r\n1 Main Videographer\r\n​1 Second Angle Videographer\r\n1 Aerial Videographer / Third Angle Candids Videographer\r\nComplete with Creative Equipments for Cinematic Shots \r\n(Stabilizers, Slider, Tripod, Etc)\r\n- 4 Professional Photographers w/ Digital SLR Camera\r\n1 Creative Photographer\r\n1 Main Photographer\r\n1 Second Angle Photographer\r\n1 Candids / Details Photographer / Onsite Photo Editor\r\n- Edited Video (20-30 mins Highlights) \r\n- 8x10 40 pages Magnetic Guestbook with Prenuptial Pictures\r\n- 8x10 40 pages Wedding Album with Leather Box\r\n- Two (2) 8x10 Parents' Album\r\n- Couple's Growing Up AVP or Then and Now Slideshow\r\n- Pre-Wedding Film with Aerial Shots (2-3 mins Prenup Video)\r\n-  SAME DAY EDIT PHOTO - Onsite Wedding Photo Highlights\r\n(3-5 mins Wedding Highlights to be played during reception)\r\n-  SAME DAY EDIT VIDEO - Onsite Wedding Video Highlights\r\n(3-5 mins  Wedding Highlights to be played during reception)\r\n- AERIAL VIDEOGRAPHY during Prenup and Wedding Day\r\n- Awesome Events 16 Gig USB for Photo / Video Highlights\r\n- 500 gig External Hard Drive for Photo / Video Files\r\n- A beautiful Memory Book to showcase your Wedding films \n\nOn the Day Coordination with Emcee\r\n------------------------\r\n- 1 Program Emcee\r\n- 4 Coordinators from Preparation to Ceremony to Reception\r\n- 1 Bride Manager to assist the bride throughout the day\r\n- 1 Groom Manager to assist the groom throughout the day", "Majesstic Wedding Package Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void wherecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IfLocation();
        }

        private void candelariavenuename_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            IfLocation();
        }

        private void lucenavenuename_SelectedIndexChanged(object sender, EventArgs e)
        {
            IfLocation();
        }
    }
    public class CustomDateTimePicker : DateTimePicker
    {
        private Color skinColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;

        private bool droppedDown = false;
        private Image calendarIcon = Properties.Resources.calendarWhite;
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;
        public Color SkinColor
        {
            get { return skinColor; }
            set
            {
                skinColor = value;
                if (skinColor.GetBrightness() >= 0.8F)
                    calendarIcon = Properties.Resources.calendarDark;
                else calendarIcon = Properties.Resources.calendarWhite;
                this.Invalidate();
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        //Constructor
        public  CustomDateTimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5F);
        }
        //Overridden methods
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }
        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            droppedDown = false;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
                RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;

                //Draw surface
                graphics.FillRectangle(skinBrush, clientArea);
                //Draw text
                graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
                //Draw open calendar icon highlight
                if (droppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);
                //Draw border 
                if (borderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                //Draw icon
                graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 9, (this.Height - calendarIcon.Height) / 2);

            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (iconButtonArea.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else this.Cursor = Cursors.Default;
        }
        //Private methods
        private int GetIconButtonWidth()
        {
            int textWidh = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textWidh <= this.Width - (calendarIconWidth + 20))
                return calendarIconWidth;
            else return arrowIconWidth;
        }
    }
}
