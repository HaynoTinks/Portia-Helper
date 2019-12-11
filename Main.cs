﻿using System;
using System.Reflection;
using Harmony;
using UnityModManagerNet;

namespace PortiaHelper
{
	static class Main
    {
		public static HarmonyInstance harmonyInstance;
		public static UnityModManager.ModEntry.ModLogger Logger;

		public static bool Load(UnityModManager.ModEntry modEntry) {
			Logger = modEntry.Logger;

			try {
				harmonyInstance = HarmonyInstance.Create(modEntry.Info.Id);
				harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());

				//modEntry.OnUpdate = OnUpdate;
			} catch (Exception ex) {
				modEntry.Logger.LogException(ex);
			}

			return true;
		}

		/*
		public static void OnUpdate(UnityModManager.ModEntry modEntry, float val) {
			//ItemSpawnerLoader.Load();
		}*/
	}
}
