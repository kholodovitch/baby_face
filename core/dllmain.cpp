// dllmain.cpp : Defines the entry point for the DLL application.
#include "stdafx.h"
#include "Core.h"

extern "C" {
	LIBRARY_API Core* Core_New();
	LIBRARY_API void Core_Delete(Core** instance);

	LIBRARY_API void Core_SetCallbackFrame(Core* instance, void* callbackAddress);

	LIBRARY_API void Core_StartStream(Core* instance);
}

LIBRARY_API Core* Core_New()
{
	return new Core();
}

LIBRARY_API void Core_Delete(Core** instance)
{
	if (instance == NULL)
		return;

	if (*instance != NULL)
	{
		Core* core = *instance;
		*instance = NULL;
		delete core;
	}
}

LIBRARY_API void Core_SetCallbackFrame(Core* instance, void* callbackAddress)
{
	instance->set_callback_frame((FrameCallback)callbackAddress);
}

LIBRARY_API void Core_StartStream(Core* instance)
{
}

BOOL APIENTRY DllMain(HMODULE hModule,
	DWORD  ul_reason_for_call,
	LPVOID lpReserved
	)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}

