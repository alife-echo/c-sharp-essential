

namespace control_threads_traffic_light;
    public static class Traffic
    {
    //vamos atender no maximo 5, mas inicialmente 3 threads
    public static Semaphore threadPool = new Semaphore(3, 5);

    // vamos atender 4 entradas para threads
    public static SemaphoreSlim semaforoSlim = new SemaphoreSlim(4);
    }

