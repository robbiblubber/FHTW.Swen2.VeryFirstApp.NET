﻿using System;



namespace FHTW.Swen2.VeryFirstApp
{
    public class GreetedEntity
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // public static members                                                                                    //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Instance.</summary>
        public static readonly GreetedEntity Instance = new();



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // public properties                                                                                        //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get; set;
        } = "World";
    }
}
