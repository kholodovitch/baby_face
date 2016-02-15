#include "stdafx.h"

typedef void(__stdcall * FrameCallback)(unsigned char*, int, int, int);


class LIBRARY_API Core {
public:
	Core(void);
	// TODO: add your methods here.

	void set_callback_frame(FrameCallback callback) {  };
};

extern LIBRARY_API int ncore;

LIBRARY_API int fncore(void);
