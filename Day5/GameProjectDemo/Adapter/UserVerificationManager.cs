using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using UserVerificationServiceReference;

namespace GameProjectDemo.Adapter
{
    public class UserVerificationManager : IUserVerificationService
    {
        public bool Validate(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(player.NationalityId, player.FirstName.ToUpper(), player.LastName.ToUpper(),
                player.BirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
