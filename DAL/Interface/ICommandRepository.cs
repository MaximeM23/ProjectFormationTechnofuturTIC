using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface ICommandRepository: IInsertRepository<Command>
    {
        int InsertCommandWine(CommandWine cw);
    }
}
