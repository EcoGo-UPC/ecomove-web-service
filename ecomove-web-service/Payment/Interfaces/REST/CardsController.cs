using System.Net.Mime;
using ecomove_web_service.Payment.Domain.Model.Queries;
using ecomove_web_service.Payment.Domain.Services;
using ecomove_web_service.Payment.Interfaces.REST.Resources;
using ecomove_web_service.Payment.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ecomove_web_service.Payment.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class CardsController(ICardCommandService commandService, ICardQueryService queryService)
    : ControllerBase
{
    [HttpPost]
    [SwaggerOperation(
        Summary = "Creates a card",
        Description = "Creates a card with a given user identifier, card number and expiration date",
        OperationId = "CreateCard")]
    [SwaggerResponse(201, "The card was created", typeof(CardResource))]
    public async Task<IActionResult> CreateCard([FromBody] CreateCardResource resource)
    {
        var createCardCommand = CreateCardFromResourceAssembler.FromResource(resource);
        var card = await commandService.Handle(createCardCommand);
        if (card is null) return BadRequest();
        var cardResource = CardResourceFromEntityAssembler.ToResourceFromEntity(card);
        return CreatedAtAction(nameof(GetCardByCardId), new {cardId = cardResource.CardId}, cardResource);
    }
    
    [HttpGet("user/{userId:int}")]
    [SwaggerOperation(
        Summary = "Gets a card by user identifier",
        Description = "Gets a card for a given user identifier",
        OperationId = "GetCardByUserId")]
    [SwaggerResponse(200, "The card was found", typeof(CardResource))]
    public async Task<IActionResult> GetCardByUserId(int userId)
    {
        var getCardByUserIdQuery = new GetCardByUserIdQuery(userId);
        var card = await queryService.Handle(getCardByUserIdQuery);
        if (card is null) return NotFound();
        var cardResource = CardResourceFromEntityAssembler.ToResourceFromEntity(card);
        return Ok(cardResource);
    }
    
    [HttpGet("id/{cardId:int}")]
    [SwaggerOperation(
        Summary = "Gets a card by card identifier",
        Description = "Gets a card for a given card identifier",
        OperationId = "GetCardByCardId")]
    [SwaggerResponse(200, "The card was found", typeof(CardResource))]
    public async Task<IActionResult> GetCardByCardId(int cardId)
    {
        var getCardByCardIdQuery = new GetCardByCardIdQuery(cardId);
        var card = await queryService.Handle(getCardByCardIdQuery);
        if (card is null) return NotFound();
        var cardResource = CardResourceFromEntityAssembler.ToResourceFromEntity(card);
        return Ok(cardResource);
    }
}