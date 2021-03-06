﻿using System;
using DevExpress.Xpo;
using System.Drawing;

namespace LeTien.Objects
{

    public class PublicHoliday : XPObject
    {
        public PublicHoliday()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public PublicHoliday(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
        [DisplayName ("Ngày Lễ")]
        public string PublicHolidayName;

        [DisplayName ("Ngày Bắt Đầu")]
        public DateTime PublicHolidayStart;

        [DisplayName ("Ngày Kết Thúc")]
        public DateTime PublicHolidayEnd;

        [Persistent("MauHienThi")]
        private Int32 _mauHienThi;
        [NonPersistent, System.ComponentModel.Browsable(false)]
        public Int32 OleMauHienThi
        {
            get { return ColorTranslator.ToOle(Color.FromArgb(_mauHienThi)); }
        }
        [DisplayName("Màu Hiển Thi")]
        [NonPersistent]
        public Color MauHienThi
        {
            get { return Color.FromArgb(_mauHienThi); }
            set
            {
                _mauHienThi = value.ToArgb();
                OnChanged("MauHienThi");
            }
        }

        [DisplayName ("Ghi Chú")]
        public string PublicHolidayDescription;
    }

}