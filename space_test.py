import pygame
import sys
import math

#satellite and earth is rock d=3.0g/cm^3

# Ekran genişliği ve yüksekliği
WIDTH, HEIGHT = 800, 600

# Renkler
BLACK = (0, 0, 0)
WHITE = (255, 255, 255)
GREEN = (0, 255, 0)
BLUE = (0,0,255)

# Dünya parametreleri

k=20


RealWr=6.371e6 #metre
WORLD_RADIUS = k #br




GRAVITATIONAL_CONSTANT = 6.67430e-11  # m^3/kg/s^2
EARTH_MASS = 5.972e24     # kg



WORLD_POSITION = (WIDTH // 2, HEIGHT // 2)
"""
GRAVITATIONAL_CONSTANT = 0.1  # Adjusted for the simulation
EARTH_MASS = 100000  # Adjusted for the simulation"""


screen = pygame.display.set_mode((WIDTH, HEIGHT))
pygame.display.set_caption("Dünya Simülasyonu")
clock = pygame.time.Clock()

running = True






COLOR_INACTIVE = pygame.Color('lightskyblue3')
COLOR_ACTIVE = pygame.Color('dodgerblue2')
pygame.font.init()

FONT = pygame.font.Font(None, 23)


class InputBox:

    def __init__(self, x, y, w, h, text='1'):
        self.rect = pygame.Rect(x, y, w, h)
        self.color = COLOR_INACTIVE
        self.text = text
        self.txt_surface = FONT.render(text, True, self.color)
        self.active = False

    def handle_event(self, event):
        if event.type == pygame.MOUSEBUTTONDOWN:
            # If the user clicked on the input_box rect.
            if self.rect.collidepoint(event.pos):
                # Toggle the active variable.
                self.active = not self.active
            else:
                self.active = False
            # Change the current color of the input box.
            self.color = COLOR_ACTIVE if self.active else COLOR_INACTIVE
        if event.type == pygame.KEYDOWN:
            if self.active:
                if event.key == pygame.K_RETURN:
                    print(self.text)
                    self.text = ''
                elif event.key == pygame.K_BACKSPACE:
                    self.text = self.text[:-1]
                else:
                    self.text += event.unicode
                # Re-render the text.
                self.txt_surface = FONT.render(self.text, True, self.color)

    def update(self):
        # Resize the box if the text is too long.
        width = max(200, self.txt_surface.get_width()+10)
        self.rect.w = width

    def draw(self, screen):
        # Blit the text.
        screen.blit(self.txt_surface, (self.rect.x+5, self.rect.y+5))
        # Blit the rect.
        pygame.draw.rect(screen, self.color, self.rect, 2)









class Satellite:
    #d=m/V
    def __init__(self, mass, radius, x, y, speed_x, speed_y):
        self.m = mass
        self.r = radius
        self.x = x
        self.y = y
        self.speed_x = speed_x
        self.speed_y = speed_y

    def calculate_location(self):
        dx = self.x - WORLD_POSITION[0]
        dy = self.y - WORLD_POSITION[1]
        distance = math.sqrt(dx**2 + dy**2)
        realdistance=(distance*RealWr)/k
        angle_rad = math.atan2(dy, dx)
        force_magnitude = -1*(GRAVITATIONAL_CONSTANT * EARTH_MASS * self.m) / (realdistance ** 2)
        force_x = force_magnitude * math.cos(angle_rad)
        force_y = force_magnitude * math.sin(angle_rad)
        self.speed_x += force_x / self.m
        self.speed_y += force_y / self.m
    
        # Bounds checking
        if False:
            if self.x < 0:
                self.x = 0
                self.speed_x = -self.speed_x
            elif self.x > WIDTH:
                self.x = WIDTH
                self.speed_x = -self.speed_x
            if self.y < 0:
                self.y = 0
                self.speed_y = -self.speed_y
            elif self.y > HEIGHT:
                self.y = HEIGHT
                self.speed_y = -self.speed_y
    
        self.x += self.speed_x
        self.y += self.speed_y
    

    def check_collision(self):
        distance = math.sqrt((self.x - WORLD_POSITION[0])**2 + (self.y - WORLD_POSITION[1])**2)
        if distance <= WORLD_RADIUS + self.r:
            return True
        else:
            return False
    
    def draw(self):
        self.calculate_location()
        if not math.isnan(self.x) and not math.isnan(self.y) and -WIDTH <= self.x <= WIDTH and -HEIGHT <= self.y <= HEIGHT:
            pygame.draw.circle(screen, BLUE, (int(self.x), int(self.y)), self.r)
        
satellites = []

def main():
    global running,EARTH_MASS,WORLD_RADIUS
    pygame.init()
    input_boxes=[InputBox(0, 0, 20, 20,text='2000'),InputBox(0,25,20,20,text=str(round((k*(2000*1000/3))/RealWr)))]
    texts=[]

    lines=[]
    while running:
        for event in pygame.event.get():
            mouse_x,mouse_y=pygame.mouse.get_pos()
            for box in input_boxes:
                box.handle_event(event)
            if event.type == pygame.QUIT:
                running = False
            elif event.type == pygame.MOUSEBUTTONDOWN:
                fx,fy= pygame.mouse.get_pos()
                lines.append([(fx,fy),(fx,fy)])
            elif event.type == pygame.MOUSEMOTION:
                if lines and fx and fy:
                    lines[-1][1]=(fx+(fx-mouse_x),fy+(fy-mouse_y))
                
            elif event.type == pygame.MOUSEBUTTONUP:
                if fx>45 and fy>45:
                    lx,ly= pygame.mouse.get_pos()
                    
                    sx=(fx-400)-(lx-400)
                    sy=(fy-300)-(ly-300)
                    print(sx,sy)
                    satellites.append(Satellite(int(input_boxes[0].text), int(input_boxes[1].text), fx, fy, sx*100000/(RealWr*40/k), sy*100000/(RealWr*50/k)))
                    print("Uydu sayısı..:",len(satellites))
                    if lines:
                        lines=[]
                    
                

        
        for box in input_boxes:
            box.update()
        
        screen.fill(BLACK)

        for box in input_boxes:
            box.draw(screen)
        
        for line in lines:
            if line[1] == 0:
                pygame.draw.line(screen, WHITE, (line[0][0],line[0][1]), (mouse_x,mouse_y), width=1)
            else:
                pygame.draw.line(screen, WHITE, (line[0][0],line[0][1]), (line[1][0],line[1][1]), width=1)
        for i in satellites:
            if i.check_collision():
                if False:
                    EARTH_MASS += i.m
                    WORLD_RADIUS += i.r
                satellites.remove(i)
                print("Uydu Dünya'ya çarpıştı! Uydu sayısı..:",len(satellites))
                
            else:
                i.draw()
        
        pygame.draw.circle(screen, GREEN, WORLD_POSITION, WORLD_RADIUS)

        
        text1 = FONT.render("r:"+str(WORLD_RADIUS), True, (255, 255, 255))
        text2 = FONT.render("mass:"+str(EARTH_MASS), True, (255, 255, 255))
        screen.blit(text1,(390,290))
        screen.blit(text2,(390,300))
        
        pygame.display.flip()
        clock.tick(60)

    pygame.quit()
    sys.exit()

if __name__ == "__main__":
    main()
