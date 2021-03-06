﻿// Used to reference Exception generic exception class
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Conductus.WIDGET.Context;

namespace Conductus.WIDGET.Controller
{
    // https://localhost:44365/widget

    // https://exceptionnotfound.net/ef-core-inmemory-asp-net-core-store-database/

    [ApiController]
    //[Route("widget")]
    [Route("[controller]")]
    public class WidgetController : ControllerBase
    {
        // Logging added
        private readonly ILogger<WidgetController> _logger;

        private readonly WidgetContextMemory _context;

        public WidgetController(WidgetContextMemory context, ILogger<WidgetController> logger)
        {
            _context = context;
            // Logging added
            _logger = logger;
        }

        // GET: widget
        // https://localhost:44365/widget
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WidgetDTO>>> GetWidgets()
        {
            try
            {
                // Logging added
                _logger.LogInformation("GET: widget");

                // Seuup test data 
                _context.SetupData();

                var widgets = await _context.Get();

                // need to pack <IEnumerable<WidgetDTO>> into ActionResult 
                return CreatedAtAction(nameof(GetWidgets), widgets);
            }
            catch (System.Exception e)
            {
                // Logging added
                _logger.LogError(e, "NoContent");

                return NoContent();
            }
        }

        // GET: widget/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WidgetDTO>> GetWidget(long id)
        {
            try
            {
                // Logging added
                _logger.LogInformation("GET: widget/{0}", id);

                var responseWidgetidget = await _context.Get(id);
                return responseWidgetidget;
            }
            catch (System.Exception e)
            {
                // Logging added
                _logger.LogError(e, "NotFound");

                return NotFound();
            }
        }

        // PUT: widget/4
        [HttpPut("{id}")]
        public async Task<ActionResult<WidgetDTO>> UpdateWidget(long id, WidgetDTO widgetDTO)
        {
            try
            {
                // Logging added
                _logger.LogInformation("PUT: widget/{0}", id);

                // Validate PUT request early before calling conte
                if (id != widgetDTO.Id)
                {
                    return BadRequest();
                }

                var responseWidgetDTO = await _context.Update(widgetDTO);
                return Ok();
            }
            catch (System.Exception e)
            {
                // Logging added
                _logger.LogError(e, "UnprocessableEntity");

                return UnprocessableEntity();
            }
        }

        // POST: widget
        [HttpPost]
        public async Task<ActionResult<WidgetDTO>> CreateWidget(WidgetDTO widgetDTO)
        {
            try
            {
                // Logging added
                _logger.LogInformation("POST: widget/{0}", widgetDTO.Id);

                var responseWidgetDTO = await _context.Create(widgetDTO);

                return Ok();
            }
            catch (System.Exception e)
            {
                // Logging added
                _logger.LogError(e, "UnprocessableEntity");

                return UnprocessableEntity();
            }
        }

        // DELETE: widget/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WidgetDTO>> DeleteWidget(long id)
        {
            try
            {
                // Logging added
                _logger.LogInformation("POST: widget/{0}", id);

                var responseWidgetDTO = await _context.Delete(id);

                return Ok();
            }
            catch (System.Exception e)
            {
                // Logging added
                _logger.LogError(e, "UnprocessableEntity");

                return UnprocessableEntity();
            }
        }
    }
}

