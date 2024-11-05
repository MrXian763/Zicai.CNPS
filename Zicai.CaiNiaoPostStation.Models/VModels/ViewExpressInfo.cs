using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.Models.VModels
{
    /// <summary>
    /// View_ExpressInfos的实体类
    /// </summary>
    [Table("View_ExpressInfos")]
    [PrimaryKey("ExpId")]
    public class ViewExpressInfo : ExpressInfo
    {
        public string StationName { get; set; }
        public string ShelfName { get; set; }
        public ViewExpressInfo() { }
        public ViewExpressInfo(ExpressInfo exp, string stationName, string shelfName)
        {
            StationName = stationName;
            ShelfName = shelfName;
            ExpId = exp.ExpId;
            ExpNumber = exp.ExpNumber;
            ExpType = exp.ExpType;
            StationId = exp.StationId;
            ShelfId = exp.ShelfId;
            Sender = exp.Sender;
            SenderAddress = exp.SenderAddress;
            SenderPhone = exp.SenderPhone;
            ReceiverPhone = exp.ReceiverPhone;
            Receiver = exp.Receiver;
            ReceiveAddress = exp.ReceiveAddress;
            ExpRemark = exp.ExpRemark;
            ExpState = exp.ExpState;
            EnterPerson = exp.EnterPerson;
            EnterTime = exp.EnterTime;
            PickWay = exp.PickWay;
        }
    }
}
