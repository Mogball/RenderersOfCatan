#version 330 core

in vec2 uv;
out vec3 color;
uniform sampler2D sampler;

void main()
{
    color = texture(sampler, uv).rgb;
}