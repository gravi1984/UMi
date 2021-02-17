using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Umi.API.Dtos;
using Umi.API.Models;
using Umi.API.Services;

namespace Umi.API.Controllers
{
    [Route("api/touristRoutes/{touristRouteId}/pictures")]
    [ApiController]
    public class TouristRoutePicturesController : ControllerBase
    {
        private ITouristRouteRepository _touristRouteRepository;
        private readonly IMapper _mapper;

        public TouristRoutePicturesController(ITouristRouteRepository touristRouteRepository, IMapper mapper)
        {
            _touristRouteRepository =
                touristRouteRepository ?? throw new ArgumentNullException(nameof(touristRouteRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetPictureListForTouristRoute(Guid touristRouteId)
        {
            // !!Db operation, extend func in Repo!!
            if (!await _touristRouteRepository.TouristRouteExistsAsync(touristRouteId))
            {
                return NotFound("tourist Route not exist");
            }
            
            var picturesFromRepo = await _touristRouteRepository.GetPicturesByTouristRouteIdAsync(touristRouteId);

            if (picturesFromRepo == null || picturesFromRepo.Count() <= 0)
            {
                return NotFound("no picture");
            }

            return Ok(_mapper.Map<IEnumerable<TouristRoutePictureDto>>(picturesFromRepo));
        }

        [HttpGet("{pictureId}", Name = "GetPicture")]
        public async Task<IActionResult> GetPicture(Guid touristRouteId, int pictureId)
        {
            // check father resource if exist
            if (! await _touristRouteRepository.TouristRouteExistsAsync(touristRouteId))
            {
                return NotFound("tourist Route not exist");
            }

            var pictureFromRepo = await _touristRouteRepository.GetPictureAsync(pictureId);
            
            // check if child resource if exist
            if (pictureFromRepo == null)
            {
                return NotFound("picture not found");
            }

            // return Dto
            return Ok(_mapper.Map<TouristRoutePictureDto>(pictureFromRepo));

        }

        [HttpPost]
        public async Task<IActionResult> CreateTouristRoutePicture(
            [FromRoute] Guid touristRouteId,
            [FromBody] TouristRoutePictureForCreationDto touristRoutePictureForCreationDto
        )
        {
            // check if touristRoute exist
            if (!await _touristRouteRepository.TouristRouteExistsAsync(touristRouteId))
            {
                return NotFound("tourist route not exist");
            }

            // create Dto -> Model
            var pictureModel = _mapper.Map<TouristRoutePicture>(touristRoutePictureForCreationDto);
            _touristRouteRepository.AddTouristRoutePicture(touristRouteId,pictureModel);
            await _touristRouteRepository.SaveAsync();

            // () -> <>
            var pictureToReturn = _mapper.Map<TouristRoutePictureDto>(pictureModel);
            return CreatedAtRoute("GetPicture",
                new {touristRouteId = pictureModel.TouristRouteId, pictureId = pictureModel.Id},
                pictureToReturn);

        }

        [HttpDelete("{pictureId}")]
        public async Task<IActionResult> DeletePicture(
            [FromRoute] Guid touristRouteId, // father route
            [FromRoute] int pictureId
            )
        {
            
            if (!await _touristRouteRepository.TouristRouteExistsAsync(touristRouteId))
            {
                return NotFound("tourist route not exist");
            }

            var pictureFromRepo = await _touristRouteRepository.GetPictureAsync(pictureId);
            
            _touristRouteRepository.DeleteTouristRoutePicture(pictureFromRepo);
            await _touristRouteRepository.SaveAsync();
            return NoContent();

        }
        
    }
}