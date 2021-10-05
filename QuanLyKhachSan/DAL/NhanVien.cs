//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class NhanVien: INotifyPropertyChanged
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.HoaDons = new HashSet<HoaDon>();
            this.PhieuThues = new HashSet<PhieuThue>();
            this.TaiKhoans = new HashSet<TaiKhoan>();
        }
    
        public int MaNV { get; set; }
        private string hoTen;
        private DateTime? nTNS;
        private string cCCD;
        private string sDT;
        private string diaChi;
        private string gioiTinh;
        private decimal? luong;
        private string chucVu;

        public string HoTen
        {
            get => hoTen;
            set
            {
                hoTen = value;
                OnPropertyChanged("HoTen");
            }
        }
        public Nullable<System.DateTime> NTNS
        {
            get => nTNS;
            set
            {
                nTNS = value;
                OnPropertyChanged("NTNS");
            }
        }
        public string CCCD
        {
            get => cCCD;
            set
            {
                cCCD = value;
                OnPropertyChanged("CCCD");
            }
        }
        public string SDT
        {
            get => sDT;
            set
            {
                sDT = value;
                OnPropertyChanged("SDT");
            }
        }
        public string DiaChi
        {
            get => diaChi;
            set
            {
                diaChi = value;
                OnPropertyChanged("DiaChi");
            }
        }
        public string GioiTinh
        {
            get => gioiTinh;
            set
            {
                gioiTinh = value;
                OnPropertyChanged("GioiTinh");
            }
        }
        public Nullable<decimal> Luong
        {
            get => luong;
            set
            {
                luong = value;
                OnPropertyChanged("Luong");
            }
        }
        public string ChucVu
        {
            get => chucVu;
            set
            {
                chucVu = value;
                OnPropertyChanged("ChucVu");
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuThue> PhieuThues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }
    }
}
