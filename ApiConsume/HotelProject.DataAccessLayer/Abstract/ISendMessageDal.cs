using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface ISendMessageDal: IGenericDal<SendMessage>
    {
        public int GetMessageCount();
    }
}