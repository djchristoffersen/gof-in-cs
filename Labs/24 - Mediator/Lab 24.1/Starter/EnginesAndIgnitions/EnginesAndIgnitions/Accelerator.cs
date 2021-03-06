﻿using System;

namespace Wincubate.MediatorLabs
{
    class Accelerator : EngineComponent
    {
        #region Properties

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    Console.WriteLine($"Accelerator {(_isEnabled ? "enabled" : "disabled")}");
                }
            }
        }
        private bool _isEnabled;

        public int TargetSpeedKmh { get; private set; }

        #endregion

        public Accelerator()
        {
            _isEnabled = false;
            TargetSpeedKmh = 0;
        }

        public void SetAccelerationTarget( int targetSpeedKmh )
        {
            if (IsEnabled)
            {
                TargetSpeedKmh = targetSpeedKmh;

                Console.WriteLine($"Speed targeted to {TargetSpeedKmh} km/h");
            }
        }
    }
}
