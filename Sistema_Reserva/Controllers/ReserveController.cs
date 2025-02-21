using Microsoft.AspNetCore.Mvc;
using Sistema_Reserva.DTO;
using Sistema_Reserva.Model;
using Sistema_Reserva.Service;

namespace Sistema_Reserva.Controllers
{
    [ApiController]
    [Route("api/reserve")]
    public class ReserveController : ControllerBase
    {
        private readonly ReserveService _reserveService;

        public ReserveController(ReserveService reserveService)
        {
            _reserveService = reserveService;
        }

        [HttpPost("create")]
        public async Task<ActionResult<ResponseModel<ReserveDTO>>> CreateReserve([FromBody] ReserveDTO reserveDTO)
        {
            try
            {
                var (reservation, participants) = await _reserveService.CreateReservationAsync(reserveDTO);

                var response = new ResponseModel<ReserveDTO>
                {
                    Data = reserveDTO,
                    Message = "Reserva criada com sucesso.",
                    Participants = participants
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
