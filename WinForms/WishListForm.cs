using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class WishListForm : Form
    {
        ListView wishListView;
        public WishListForm()
        {
            InitializeComponent();

            wishListView = new ListView();

            wishListView.Bounds = new Rectangle(new Point(10, 50), new Size(250, 200));
            wishListView.View = View.Details;
            wishListView.LabelEdit = true;
            wishListView.AllowColumnReorder = true;
            wishListView.CheckBoxes = true;
            wishListView.GridLines = true;
            wishListView.Sorting = SortOrder.Ascending;

            wishListView.Columns.Add("Item", 100, HorizontalAlignment.Left);
            wishListView.Columns.Add("Price $", 60, HorizontalAlignment.Center);

            var imageList = new ImageList();
            imageList.Images.Add(Bitmap.FromFile("1.jpg"));
            imageList.Images.Add(Bitmap.FromFile("2.jpg"));
            imageList.Images.Add(Bitmap.FromFile("3.jpg"));

            ListViewItem item1 = new ListViewItem("Ducati XDiavel", 0);
            item1.SubItems.Add("25000");

            ListViewItem item2 = new ListViewItem("Домашний Крокодил", 1);
            item2.SubItems.Add("2000");

            ListViewItem item3 = new ListViewItem("Домашняя Обезьяна", 2);
            item3.SubItems.Add("1000");

            wishListView.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            wishListView.LargeImageList = imageList;
            wishListView.SmallImageList = imageList;

            this.Controls.Add(wishListView);

        }
    }
}
