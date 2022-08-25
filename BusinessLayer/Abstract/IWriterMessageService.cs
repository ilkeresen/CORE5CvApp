using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterMessageService : IGenericService<WriterMessage>
    {
        List<WriterMessage> GetListSenderMessage(string filter);
        List<WriterMessage> GetListReceiverMessage(string filter);
        List<WriterMessage> GetListTrashMessage(string filter);
    }
}
