﻿using Xamarin.Forms;

namespace DoingThing.Views
{
    public interface ISettingsPage2
    {
        bool On { get; set; }
        bool Equals(object obj);
        int GetHashCode();
        SizeRequest GetSizeRequest(double widthConstraint, double heightConstraint);
        string ToString();
    }
}