﻿/*
 * Copyright (C) 2014 
 * Author: Ruben Macias
 * http://MobileTech.com @MobileTech
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 */

using System;
using MonoTouch.UIKit;
using System.Drawing;
using System.Collections.Generic;

namespace MobileTech.ModalPicker
{
    public class CustomPickerModel : UIPickerViewModel
    {
        private List<string> _itemsList;

        public CustomPickerModel(List<string> itemsList)
        {
            _itemsList = itemsList;
        }

        public override int GetComponentCount(UIPickerView picker)
        {
            return 1;
        }

        public override int GetRowsInComponent(UIPickerView picker, int component)
        {
            return _itemsList.Count;
        }

        public override UIView GetView(UIPickerView picker, int row, int component, UIView view)
        {
            var label = new UILabel(new RectangleF(0, 0, 300, 37))
            {
                BackgroundColor = UIColor.Clear,
                Text = _itemsList[row],
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.BoldSystemFontOfSize(22.0f)
            };

            return label;
        }
    }
}

