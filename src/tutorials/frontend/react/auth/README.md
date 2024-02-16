# Authentication and Authorization

## Installation

## Init nextjs project

```
npx create-next-app@latest auth
```

## Shadcn UI

```
npx shadcn-ui@latest init
npx shadcn-ui@latest add button
npx shadcn-ui@latest add card
npx shadcn-ui@latest add form
npx shadcn-ui@latest add input
npx shadcn-ui@latest add sonner
npx shadcn-ui@latest add switch
npx shadcn-ui@latest add select
npx shadcn-ui@latest add dropdown-menu
npx shadcn-ui@latest add avatar
npx shadcn-ui@latest add badge
npx shadcn-ui@latest add dialog
```

## React Icons

```
npm i react-icons
```

## Zod

```
npm install zod
```

## Prisma

```
npm i -D prisma
npm i @prisma/client
npm install @auth/prisma-adapter
npx prisma init
npx prisma generate
npx prisma db push
```

## Next Auth

```
npm install next-auth
```

## Bcrypt

```
npm i bcrypt
npm i -D @types/bcrypt
npm i bcryptjs
npm i -D @types/bcryptjs
```

## UUID

```
npm i uuid
npm i --save-dev @types/uuid
```

## react-spinners

```
npm install react-spinners
```

# Useful commands

## Open prisma studio

```
npx prisma studio
```

Now visit the following url with default port: 5555

```
http://localhost:5555
```

To migrate schema write the following command.

```
npx prisma migrate reset
```

## Setup resend

Go to https://resend.com to get started

Install resend package

```
npm install resend
```

# Run

First, run the development server:

```bash
npm run dev
# or
yarn dev
# or
pnpm dev
# or
bun dev
```

## Build
To build for production deployment write the following command
```
npm run build
```

Open [http://localhost:3000](http://localhost:3000) with your browser to see the result.

You can start editing the page by modifying `app/page.tsx`. The page auto-updates as you edit the file.

This project uses [`next/font`](https://nextjs.org/docs/basic-features/font-optimization) to automatically optimize and load Inter, a custom Google Font.

## Learn More

To learn more about Next.js, take a look at the following resources:

- [Next.js Documentation](https://nextjs.org/docs) - learn about Next.js features and API.
- [Learn Next.js](https://nextjs.org/learn) - an interactive Next.js tutorial.

You can check out [the Next.js GitHub repository](https://github.com/vercel/next.js/) - your feedback and contributions are welcome!

## Deploy on Vercel

The easiest way to deploy your Next.js app is to use the [Vercel Platform](https://vercel.com/new?utm_medium=default-template&filter=next.js&utm_source=create-next-app&utm_campaign=create-next-app-readme) from the creators of Next.js.

Check out our [Next.js deployment documentation](https://nextjs.org/docs/deployment) for more details.
