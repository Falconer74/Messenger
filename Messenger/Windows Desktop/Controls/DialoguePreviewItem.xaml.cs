﻿using System;
using System.Collections.Generic;
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

using Windows_Desktop.Classes;

namespace Windows_Desktop.Controls
{
    /// <summary>
    /// Interaction logic for DialoguePreviewItem.xaml
    /// </summary>
    public partial class DialoguePreviewItem : UserControl, ConversationPreviewItem
    {
        //Text of last message
        public string Text
        {
            get
            {
                return Label_MessageText.Content.ToString();
            }
            set
            {
                Label_MessageText.Content = value;
            }
        }

        //Image of group or interlocutor
        public int Image { get; set; } //Image not returning now

        //Time of last reveived message
        public string Time
        {
            get
            {
                return Label_MessageTime.Content.ToString();
            }
            set
            {
                Label_MessageTime.Content = value;
            }
        }

        //Amount of unread messages
        public int Unread { get; set; } //Amount of unread messages not returning now

        public DialoguePreviewItem()
        {
            InitializeComponent();
        }

        
        public void InitializePreview()
        {
            throw new NotImplementedException();
        }
    }
}
