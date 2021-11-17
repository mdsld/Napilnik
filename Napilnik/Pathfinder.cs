﻿using System;

namespace Napilnik
{
    class Pathfinder
    {
        private readonly ILogger _logger;

        public Pathfinder(ILogger logger)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            _logger = logger;
        }

        public void Find()
        {
            _logger.Log("Find");
        }
    }
}