using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ClientManager: IClientService
    {
        IClientDal _clientDal;
        public ClientManager(IClientDal clientDal)
        {
            _clientDal = clientDal;
        }


        public IResult Add(Client client)
        {
            _clientDal.Add(client);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Client client)
        {
            _clientDal.Delete(client);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Client>> GetAll()
        {
            return new SuccessDataResult<List<Client>>(_clientDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Client> GetById(int clientId)
        {
            return new SuccessDataResult<Client>(_clientDal.Get(c => c.ClientId == clientId));
        }

        public IResult Update(Client client)
        {
            _clientDal.Update(client);
            return new SuccessResult(Messages.Updated);
        }
    }
}
