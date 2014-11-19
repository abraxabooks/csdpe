/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter18
{
    public class EngineManagementSystem
    {
        private Ignition ignition;
        private Gearbox gearbox;
        private Accelerator accelerator;
        private Brake brake;

        private int currentSpeed;

        public EngineManagementSystem()
        {
            currentSpeed = 0;
        }


        // Methods that enable registration with this mediator...

        public virtual void RegisterIgnition(Ignition ignition)
        {
            this.ignition = ignition;
        }

        public virtual void RegisterGearbox(Gearbox gearbox)
        {
            this.gearbox = gearbox;
        }

        public virtual void RegisterAccelerator(Accelerator accelerator)
        {
            this.accelerator = accelerator;
        }

        public virtual void RegisterBrake(Brake brake)
        {
            this.brake = brake;
        }


        // Methods that handle object interactions...

        public virtual void IgnitionTurnedOn()
        {
            gearbox.Enable();
            accelerator.Enable();
            brake.Enable();
        }

        public virtual void IgnitionTurnedOff()
        {
            gearbox.Disable();
            accelerator.Disable();
            brake.Disable();
        }

        public virtual void GearboxEnabled()
        {
            Console.WriteLine("EMS now controlling the gearbox");
        }

        public virtual void GearboxDisabled()
        {
            Console.WriteLine("EMS no longer controlling the gearbox");
        }

        public virtual void GearChanged()
        {
            Console.WriteLine("EMS disengaging revs while gear changing");
        }

        public virtual void AcceleratorEnabled()
        {
            Console.WriteLine("EMS now controlling the accelerator");
        }

        public virtual void AcceleratorDisabled()
        {
            Console.WriteLine("EMS no longer controlling the accelerator");
        }

        public virtual void AcceleratorPressed()
        {
            brake.Disable();
            while (currentSpeed < accelerator.Speed)
            {
                currentSpeed++;
                Console.WriteLine("Speed currentlt " + currentSpeed);

                // Set gear according to speed
                if (currentSpeed <= 10)
                {
                    gearbox.Gear = Gear.First;

                }
                else if (currentSpeed <= 20)
                {
                    gearbox.Gear = Gear.Second;

                }
                else if (currentSpeed <= 30)
                {
                    gearbox.Gear = Gear.Third;

                }
                else if (currentSpeed <= 50)
                {
                    gearbox.Gear = Gear.Fourth;

                }
                else
                {
                    gearbox.Gear = Gear.Fifth;
                }
            }
            brake.Enable();
        }

        public virtual void BrakeEnabled()
        {
            Console.WriteLine("EMS now controlling the brake");
        }

        public virtual void BrakeDisabled()
        {
            Console.WriteLine("EMS no longer controlling the brake");
        }

        public virtual void BrakePressed()
        {
            accelerator.Disable();
            currentSpeed = 0;
        }

        public virtual void BrakeReleased()
        {
            gearbox.Gear = Gear.First;
            accelerator.Enable();
        }

    }
}
