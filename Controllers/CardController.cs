using Microsoft.AspNetCore.Mvc;
using refueling.Domain;
using refueling.Repository;

namespace refueling.Controllers
{
    [ApiController]
    [Route("/card")]
    public class CardController : ControllerBase
    {
        [HttpPut]
        public Card Create(Card card)
        {
            Storage.CardStorage.Create(card);
            return card;
        }

        [HttpGet]
        public Card Read(int cardId)
        {
            return Storage.CardStorage.Read(cardId);;
        }

        [HttpPatch]
        public Card Update(int cardId, Card newCard)
        {
            return Storage.CardStorage.Update(cardId, newCard);
        }

        [HttpDelete]
        public bool Delete(int cardId)
        {
            return Storage.CardStorage.Delete(cardId);
        }
    }
}