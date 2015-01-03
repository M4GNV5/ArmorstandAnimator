using ArmorstandAnimator.Core;
using ArmorstandAnimator.GUI.XAML.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArmorstandAnimator.GUI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			AnimationManager animation = new AnimationManager();
			ArmorstandState initial = ArmorstandManager.CreateArmorstand();
			Dictionary<float, ArmorstandState> keyframes = new Dictionary<float, ArmorstandState>();
			keyframes.Add(0, initial.Copy());
			initial.HeadPose.Y = 45;
			keyframes.Add(3, initial.Copy());
			initial.HeadPose.Y = 20;
			keyframes.Add(4, initial.Copy());
			animation.AddKeyframes(keyframes);

			InitializeComponent();
		}

		private void menuItemChilds(object sender, MouseButtonEventArgs e)
		{
			if (sender is MenuItem)
			{
				(sender as MenuItem).IsSubmenuOpen = true;
				e.Handled = true;
			}
		}
	}
}