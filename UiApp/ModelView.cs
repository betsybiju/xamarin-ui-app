using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace UiApp
{
    public class ModelView : ContentView
    {
        private Policy _oldpolicy;
        public ObservableCollection<Policy> Policies { get; set; }
        public ModelView()
        {
            Policies = new ObservableCollection<Policy>
            {
                new Policy
                {
                    Image="c",
                    Title="Active Policy",
                    Img="arrowdown",
                    SubItem1="View Policy List",
                    SubItem2="Download Policy Schedule",
                    SubItem3="View Premium Reciept",
                    SubItem4="View Product Benefits",
                    SubItem5="Surrendering Policy",
                    SubItem6="Mail Me Policy",
                    arrow="arrowside",
                    IsVisible = false,
                },
                new Policy
                {
                    Image="ch",
                    Title="Policy Changes",
                    Img="arrowdown",
                     SubItem1="View Policy List",
                    SubItem2="Download Policy Schedule",
                    SubItem3="View Premium Reciept",
                    SubItem4="View Product Benefits",
                    SubItem5="Surrendering Policy",
                    SubItem6="Mail Me Policy",
                    arrow="arrowside",
                    IsVisible = false,
                },
                new Policy
                {
                    Image="cha",
                    Title="Lapsed Policy",
                    Img="arrowdown",
                    SubItem1="View Policy List",
                    SubItem2="Download Policy Schedule",
                    SubItem3="View Premium Reciept",
                    SubItem4="View Product Benefits",
                    SubItem5="Surrendering Policy",
                    SubItem6="Mail Me Policy",
                    arrow="arrowside",
                    IsVisible = false,
                },
                 new Policy
                {
                     Image="chan",
                    Title="Payments",
                    Img="arrowdown",
                   SubItem1="View Policy List",
                    SubItem2="Download Policy Schedule",
                    SubItem3="View Premium Reciept",
                    SubItem4="View Product Benefits",
                    SubItem5="Surrendering Policy",
                    SubItem6="Mail Me Policy",
                    arrow="arrowside",
                    IsVisible = false,
                }

            };

        }

        internal void ShowOrHidePolicy(Policy policy)
        {
            _oldpolicy = policy;
            if (_oldpolicy==policy)
            {
                if(policy.Img=="arrowdown")
                {
                    policy.Img = "arrowup";
                }
                else
                {
                    policy.Img = "arrowdown";
                }
                policy.IsVisible = !policy.IsVisible;
                UpdatePolicies(policy);
            }
            else
            {
                if(_oldpolicy!=null)
                {
                    _oldpolicy.IsVisible = false;
                    policy.Img = "arrowdown";
                    UpdatePolicies(_oldpolicy);
                }
                policy.IsVisible = true;
                policy.Img = "arrowdown";
                UpdatePolicies(policy);
            }
        }

        private void UpdatePolicies(Policy policy)
        {
            var index = Policies.IndexOf(policy);
            Policies.Remove(policy);
            Policies.Insert(index,policy);
        }
    }
}